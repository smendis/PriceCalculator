using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Engine;
using System.Data;

namespace Engine.Store
{
    class InLocalDB : IStore
    {
        string conString = Properties.Settings.Default.dbConnectionString;

        public void AddCustomer(Customer customer)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                int customerId = 0;
                using (SqlCommand com = new SqlCommand("INSERT INTO Customer(Name) VALUES(@Name)", con))
                {
                    com.Parameters.AddWithValue("@Name", customer.Name);
                    com.ExecuteNonQuery();
                }

                using (SqlCommand com = new SqlCommand("SELECT Id FROM Customer WHERE Name='" + customer.Name+"'", con))
                {
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            customerId = (int)reader["Id"];
                        }
                    }
                    reader.Close();
                }
                
                foreach (Rebate r in customer.RebateAgreement)
                {
                    using (SqlCommand com = new SqlCommand("INSERT INTO CustomerRebateScheme(CustomerId, RebateId) VALUES(@CustomerId, @RebateId)", con))
                    {
                        com.Parameters.AddWithValue("@CustomerId", customerId);
                        com.Parameters.AddWithValue("@RebateId", r.Id);
                        com.ExecuteNonQuery();
                    }
                }
                
            }
        }

        public void AddProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("INSERT INTO Product(Name,StandardPrice) VALUES(@Name, @StandardPrice)", con))
                {
                    com.Parameters.AddWithValue("@Name", product.Name);
                    com.Parameters.AddWithValue("@StandardPrice", product.StandardPrice);
                    com.ExecuteNonQuery();
                }
            }
        }

        public void AddRebate(Rebate rebate)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("INSERT INTO Rebate(Name, ProductId, Discount, Volume, StartDate, EndDate, RebateType) VALUES(@Name, @ProductId, @Discount, @Volume, @StartDate, @EndDate, @RebateType)", con))
                {
                    com.Parameters.AddWithValue("@Name", rebate.Name);
                    com.Parameters.AddWithValue("@ProductId", rebate.Product.Id);
                    com.Parameters.AddWithValue("@Discount", (decimal)rebate.Discount);

                    if (rebate.GetType() == typeof(VolumeBasedRebate))
                    {
                        VolumeBasedRebate r = (VolumeBasedRebate)rebate;
                        com.Parameters.AddWithValue("@Volume", r.Volume);
                        com.Parameters.AddWithValue("@StartDate", DateTime.Now.AddYears(-1).ToString());
                        com.Parameters.AddWithValue("@EndDate", DateTime.Now.AddYears(10).ToString());
                        com.Parameters.AddWithValue("@RebateType", "VOLUME");
                    }
                    else if (rebate.GetType() == typeof(SeasonalRebate))
                    {
                        SeasonalRebate r = (SeasonalRebate)rebate;
                        com.Parameters.AddWithValue("@Volume", 1);
                        com.Parameters.AddWithValue("@StartDate", r.Start);
                        com.Parameters.AddWithValue("@EndDate", r.End);
                        com.Parameters.AddWithValue("@RebateType", "SEASONAL");
                    }
                    else
                    {
                        SpecialRebate r = (SpecialRebate)rebate;
                        com.Parameters.AddWithValue("@Volume", r.Volume);
                        com.Parameters.AddWithValue("@StartDate", r.Start);
                        com.Parameters.AddWithValue("@EndDate", r.End);
                        com.Parameters.AddWithValue("@RebateType", "SPECIAL");
                    }

                    com.ExecuteNonQuery();
                }
            }
        }

        public Customer GetCustomer(int id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("SELECT * FROM Customer WHERE Id =" + id, con))
                {
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();

                        Customer cust = new Customer();
                        cust.Id = (int)reader["Id"];
                        cust.Name = reader["Name"].ToString();

                        List<Rebate> rebateList = new List<Rebate>();
                        com.CommandText = "SELECT RebateId FROM CustomerRebateScheme WHERE CustomerId =" + id;
                        reader.Close();
                        reader = com.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                rebateList.Add(GetRebate((int)reader["RebateId"]));
                            }
                        }
                        cust.RebateAgreement = rebateList;

                        return cust;
                    }
                }

                return null;
            }
        }

        public Product GetProduct(int id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("SELECT * FROM Product WHERE Id =" + id, con))
                {
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();

                        Product prod = new Product();
                        prod.Id = (int)reader["Id"];
                        prod.Name = reader["Name"].ToString();
                        prod.StandardPrice = (double)(decimal)reader["StandardPrice"];

                        return prod;
                    }
                }

                return null;
            }
        }

        public Rebate GetRebate(int id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {

                con.Open();

                using (SqlCommand com = new SqlCommand("SELECT * FROM Rebate WHERE Id =" + id, con))
                {
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();

                        string _type = reader["RebateType"].ToString();
                        int _id = (int)reader["Id"];
                        string _name = reader["Name"].ToString();
                        Product _product = GetProduct((int)reader["ProductId"]);
                        double _discount = (double)(decimal)reader["Discount"];

                        if (_type == "VOLUME")
                        {
                            int _volume = (int)reader["Volume"];
                            return new VolumeBasedRebate(_id, _name, _product, _discount, _volume);
                        }
                        else if (_type == "SEASONAL")
                        {
                            DateTime _start = (DateTime)reader["StartDate"];
                            DateTime _end = (DateTime)reader["EndDate"];
                            return new SeasonalRebate(_id, _name, _product, _discount, _start, _end);
                        }
                        else
                        {
                            int _volume = (int)reader["Volume"];
                            DateTime _start = (DateTime)reader["StartDate"];
                            DateTime _end = (DateTime)reader["EndDate"];
                            return new SpecialRebate(_id, _name, _product, _discount, _volume, _start, _end);
                        }
                    }
                    return null;
                }
            }
        }

        public List<Customer> GetAllCustomers()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                List<Customer> list = new List<Customer>();

                using (SqlCommand com = new SqlCommand("SELECT Id FROM Customer", con))
                {
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Customer cust = GetCustomer((int)reader["Id"]);
                        list.Add(cust);
                    }
                }

                return list;
            }
        }

        public List<Product> GetAllProducts()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                List<Product> list = new List<Product>();

                using (SqlCommand com = new SqlCommand("SELECT * FROM Product", con))
                {
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.Id = (int)reader["Id"];
                        prod.Name = reader["Name"].ToString();
                        prod.StandardPrice = (double)(decimal)reader["StandardPrice"];
                        list.Add(prod);
                    }
                }

                return list;
            }
        }

        public List<Rebate> GetAllRebates()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                List<Rebate> list = new List<Rebate>();

                using (SqlCommand com = new SqlCommand("SELECT Id FROM Rebate", con))
                {
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Rebate rebate = GetRebate((int)reader["Id"]);
                        list.Add(rebate);
                    }
                }

                return list;
            }
        }


        public void RemoveCustomer(int id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("DELETE FROM Customer WHERE Id=" + id + "; DELETE FROM CustomerRebateScheme WHERE CustomerId=" + id + ";", con))
                {
                    com.ExecuteNonQuery();
                }
            }
        }

        public void RemoveProduct(int id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("DELETE FROM Product WHERE Id=" + id, con))
                {
                    com.ExecuteNonQuery();

                    com.CommandText = "SELECT Id FROM Rebate WHERE ProductId=" + id;
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        RemoveRebate((int)reader["Id"]);
                    }
                }
            }
        }

        public void RemoveRebate(int id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("DELETE FROM Rebate WHERE Id=" + id + "; DELETE FROM CustomerRebateScheme WHERE RebateId=" + id + ";", con))
                {
                    com.ExecuteNonQuery();
                }
            }
        }


        public void EditCustomer(int id, Customer customer)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string query = String.Format("UPDATE Customer SET Name='{0}' WHERE Id={1}", customer.Name, id);
                using (SqlCommand com = new SqlCommand(query, con))
                {
                    com.ExecuteNonQuery();
                    query = String.Format("DELETE FROM CustomerRebateScheme WHERE CustomerId={0}", id);
                    com.CommandText = query;
                    com.ExecuteNonQuery();
                }

                foreach (Rebate r in customer.RebateAgreement)
                {
                    using (SqlCommand com = new SqlCommand("INSERT INTO CustomerRebateScheme(CustomerId, RebateId) VALUES(@CustomerId, @RebateId)", con))
                    {
                        com.Parameters.AddWithValue("@CustomerId", customer.Id);
                        com.Parameters.AddWithValue("@RebateId", r.Id);
                        com.ExecuteNonQuery();
                    }
                }
            }
        }

        public void EditProduct(int id, Product product)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string query = String.Format("UPDATE Product SET Name='{0}', StandardPrice='{1}' WHERE Id={2}", product.Name, product.StandardPrice, id);
                using (SqlCommand com = new SqlCommand(query, con))
                {
                    com.ExecuteNonQuery();
                }
            }
        }

        public void EditRebate(int id, Rebate rebate)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand())
                {
                    string query = String.Format("UPDATE Rebate SET Name='{0}', ProductId='{1}', Discount='{2}', ", rebate.Name, rebate.Product.Id, (decimal)rebate.Discount);


                    if (rebate.GetType() == typeof(VolumeBasedRebate))
                    {
                        VolumeBasedRebate r = (VolumeBasedRebate)rebate;
                        query += String.Format("Volume='{0}', StartDate='{1}', EndDate='{2}', RebateType='{3}' WHERE Id={4}", r.Volume, DateTime.Now.AddYears(-1).ToString(), DateTime.Now.AddYears(10).ToString(), "VOLUME", id);
                    }
                    else if (rebate.GetType() == typeof(SeasonalRebate))
                    {
                        SeasonalRebate r = (SeasonalRebate)rebate;
                        query += String.Format("Volume='{0}', StartDate='{1}', EndDate='{2}', RebateType='{3}' WHERE Id={4}", 1, r.Start, r.End, "SEASONAL", id);
                    }
                    else
                    {
                        SpecialRebate r = (SpecialRebate)rebate;
                        query += String.Format("Volume='{0}', StartDate='{1}', EndDate='{2}', RebateType='{3}' WHERE Id={4}", r.Volume, r.Start, r.End, "SPECIAL", id);
                    }

                    com.CommandText = query;
                    com.Connection = con;
                    com.ExecuteNonQuery();
                }
            }
        }
    }
}
