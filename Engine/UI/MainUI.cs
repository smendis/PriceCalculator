using Engine.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine.UI
{
    public partial class MainUI : Form
    {
        private IEngine engine = null;

        public MainUI()
        {
            engine = new Engine.Engine();

            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = new[] { "Products", "Rebate Agreements", "Customers"};
            cmbCategory.SelectedIndex = 0;

            onCalculatorTabSelected();
        }

        private void tabMain_TabIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    onCalculatorTabSelected();
                    break;
                case 1:
                    onAddProductTabSelected();
                    break;
                case 2:
                    onAddRebateTabSelected();
                    break;
                case 3:
                    onAddCustomerTabSelected();
                    break;
                default:
                    onManageTabSelected();
                    break;
            }
        }
        private void onCalculatorTabSelected()
        {
            cmbCalcCustomer.Items.Clear();
            cmbCalcCustomer.Items.AddRange(engine.GetAllCustomers().ToArray());

            cmbCalcProduct.Items.Clear();
            cmbCalcProduct.Items.AddRange(engine.GetAllProducts().ToArray());

            txtCalcQuantity.Text = "";
            lblCalcPrice.Text = String.Format("{0:C}", 0.0) + " per unit";

            toolStripStatus.Text = "Ready..";
        }

        private void onAddProductTabSelected()
        {
            cmbProdName.Items.Clear();
            cmbProdName.Items.AddRange(engine.GetAllProducts().ToArray());
            txtProdName.Text = "";
            txtProdPrice.Text = "";

            toolStripStatus.Text = "Ready..";
        }

        private void onAddRebateTabSelected()
        {
            cmbRebName.Items.Clear();
            cmbRebName.Items.AddRange(engine.GetAllRebates().ToArray());
            txtRebName.Text = "";
            cmbRebProduct.Items.Clear();
            cmbRebProduct.Items.AddRange(engine.GetAllProducts().ToArray());
            txtRebDiscount.Text = "";
            rdbRebVolume.Checked = true;

            toolStripStatus.Text = "Ready..";
        }

        private void onAddCustomerTabSelected()
        {
            cmbCusName.Items.Clear();
            cmbCusName.Items.AddRange(engine.GetAllCustomers().ToArray());
            chkCusAgreements.Items.Clear();
            chkCusAgreements.Items.AddRange(engine.GetAllRebates().ToArray());

            toolStripStatus.Text = "Ready..";
        }

        private void onManageTabSelected()
        {
            gridCustomer.DataSource = GridUtil.GetAllGridCustomers(engine.GetAllCustomers());
            gridProduct.DataSource = GridUtil.GetAllGridProducts(engine.GetAllProducts());
            gridRebate.DataSource = GridUtil.GetAllGridRebates(engine.GetAllRebates());

            toolStripStatus.Text = "Ready..";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (InputValidate())
            {
                int customerId = ((Customer)cmbCalcCustomer.SelectedItem).Id;
                int productId = ((Product)cmbCalcProduct.SelectedItem).Id;
                int quantity = int.Parse(txtCalcQuantity.Text);

                double discountedPrice = engine.CalculatePrice(customerId, productId, quantity);

                lblCalcPrice.Text = String.Format("{0:C}", discountedPrice) + " per unit";
                toolStripStatus.Text = "Discounted price calculated..";
            }
        }


        private void btnProdNew_Click(object sender, EventArgs e)
        {
            if (IsNew())
            {
                cmbProdName.Visible = true;
                txtProdName.Visible = false;
                SetExistingProductValues();


                btnProd.Text = "Edit Product";
                btnProdNew.BackgroundImage = Resource.add;
                toolTip.SetToolTip(btnProdNew, "Add New Product");
            }
            else
            {
                cmbProdName.Visible = false;
                txtProdName.Visible = true;
                SetExistingProductValues();

                btnProd.Text = "Add Product";
                btnProdNew.BackgroundImage = Resource.edit;
                toolTip.SetToolTip(btnProdNew, "Change Existing Product");
            }
        }

        private void SetExistingProductValues()
        {
            if (!IsNew() && cmbProdName.SelectedItem != null)
                txtProdPrice.Text = ((Product)cmbProdName.SelectedItem).StandardPrice.ToString();
            else
                txtProdPrice.Text = "";
        }

        private void cmbProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetExistingProductValues();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            if (InputValidate())
            {
                double price = double.Parse(txtProdPrice.Text.Trim().Replace(",", "").Replace(" ", ""));
                try
                {
                    if (IsNew())
                    {
                        string name = txtProdName.Text.Trim();
                
                        engine.AddProduct(name, price);
                        toolStripStatus.Text = "Product added to the system..";
                        MessageBox.Show("Product added to the system.", "Price Calculator");
                    }
                    else
                    {
                        int id = ((Product)cmbProdName.SelectedItem).Id;
                        string name = ((Product)cmbProdName.SelectedItem).Name;

                        engine.EditProduct(id, name, price);

                        toolStripStatus.Text = "Changes to the product saved..";
                        MessageBox.Show("Product changes saved successfully.", "Price Calculator");
                    }
                    //refresh all
                    onAddProductTabSelected();
                }
                catch
                {
                    toolStripStatus.Text = "Error occured while saving the product to the system..";
                    MessageBox.Show("Unabled to save the product in the system. Please try again.", "Price Calculator");
                }
            }
        }

        private void btnRebNew_Click(object sender, EventArgs e)
        {
            if (IsNew())
            {
                cmbRebName.Visible = true;
                txtRebName.Visible = false;
                SetExistingRebateValues();


                btnReb.Text = "Edit Agreement";
                btnRebNew.BackgroundImage = Resource.add;
                toolTip.SetToolTip(btnRebNew, "Add New Rebate Agreement");
            }
            else
            {
                cmbRebName.Visible = false;
                txtRebName.Visible = true;
                SetExistingRebateValues();

                btnReb.Text = "Add Agreement";
                btnRebNew.BackgroundImage = Resource.edit;
                toolTip.SetToolTip(btnRebNew, "Change Existing Rebate Agreement");
            }
        }

        private void SetExistingRebateValues()
        {
            if (!IsNew() && cmbRebName.SelectedItem != null)
            {
                Rebate item = (Rebate)cmbRebName.SelectedItem;
                for (int i = 0; i < cmbRebProduct.Items.Count; i++)
                {
                    Product p = (Product)cmbRebProduct.Items[i];
                    if (p.Id == item.Product.Id)
                        cmbRebProduct.SelectedIndex = i;
                }
                txtRebDiscount.Text = item.Discount.ToString();
                if (item.GetType() == typeof(VolumeBasedRebate))
                {
                    rdbRebVolume.Checked = true;
                    VolumeBasedRebate r = (VolumeBasedRebate)item;
                    txtRebVolQuantity.Text = r.Volume.ToString();
                }
                else if (item.GetType() == typeof(SeasonalRebate))
                {
                    rdbRebSeasonal.Checked = true;
                    SeasonalRebate r = (SeasonalRebate)item;
                    dateRebSeasonalStart.Value = r.Start;
                    dateRebSeasonalEnd.Value = r.End;
                }
                else
                {
                    rdbRebSpecial.Checked = true;
                    SpecialRebate r = (SpecialRebate)item;
                    txtRebSpecialQuantity.Text = r.Volume.ToString();
                    dateRebSpecialStart.Value = r.Start;
                    dateRebSpecialEnd.Value = r.End;
                }
            }
            else
            {
                cmbRebProduct.SelectedItem = null;
                txtRebDiscount.Text = "";
                rdbRebVolume.Checked = true;
                txtRebVolQuantity.Text = "";
                dateRebSeasonalStart.Value = DateTime.Now;
                dateRebSeasonalEnd.Value = DateTime.Now;
                txtRebSpecialQuantity.Text = "";
                dateRebSpecialStart.Value = DateTime.Now;
                dateRebSpecialEnd.Value = DateTime.Now;
            }
        }

        private void cmbRebName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetExistingRebateValues();
        }

        private void rdbRebType_CheckedChanged(object sender, EventArgs e)
        {
            pnlRebVolume.Visible = (rdbRebVolume.Checked);
            pnlRebSeasonal.Visible = (rdbRebSeasonal.Checked);
            pnlRebSpecial.Visible = (rdbRebSpecial.Checked);
        }

        private void btnReb_Click(object sender, EventArgs e)
        {
            if (InputValidate())
            {
                int productId = ((Product)cmbRebProduct.SelectedItem).Id;
                double discount = double.Parse(txtRebDiscount.Text);
                int quantity;
                DateTime start;
                DateTime end;
                string type;
                if (rdbRebVolume.Checked)
                {
                    quantity = int.Parse(txtRebVolQuantity.Text);
                    start = DateTime.Now.AddYears(-1);
                    end = DateTime.Now.AddYears(+10);
                    type = "Volume";
                }
                else if (rdbRebSeasonal.Checked)
                {
                    quantity = 1;
                    start = dateRebSeasonalStart.Value;
                    end = dateRebSeasonalEnd.Value;
                    type = "Seasonal";
                }
                else
                {
                    quantity = int.Parse(txtRebSpecialQuantity.Text);
                    start = dateRebSpecialStart.Value;
                    end = dateRebSpecialEnd.Value;
                    type = "Special";
                }

                try
                {
                    if(IsNew())
                    {
                        string name = txtRebName.Text;

                        engine.AddRebate(name, type, productId, discount, quantity, start, end);
                        toolStripStatus.Text = "Rebate agreement successfully added to the system..";
                        MessageBox.Show("Rebate agreement successfully added to the system.", "Price Calculator");
                    }
                    else{
                        int id = ((Rebate)cmbRebName.SelectedItem).Id;
                        string name = ((Rebate)cmbRebName.SelectedItem).Name;

                        engine.EditRebate(id, name, type, productId, discount, quantity, start, end);

                        toolStripStatus.Text = "Changes to the rebate agreement successfully saved..";
                        MessageBox.Show("Rebate agreement successfully changed.", "Price Calculator");
                    }
                    //refresh all
                    onAddRebateTabSelected();
                }
                catch
                {
                    toolStripStatus.Text = "Error occured while saving the agreement to the system..";
                    MessageBox.Show("Unable to save the rebate agreement to the system. Please try again", "Price Calculator");
                }
            }
        }


        private void btnCusNew_Click(object sender, EventArgs e)
        {
            if (IsNew())
            {
                cmbCusName.Visible = true;
                txtCusName.Visible = false;
                SetExistingCustomerValues();


                btnCus.Text = "Edit Customer";
                btnCusNew.BackgroundImage = Resource.add;
                toolTip.SetToolTip(btnCusNew, "Add New Customer");
            }
            else
            {
                cmbCusName.Visible = false;
                txtCusName.Visible = true;
                SetExistingCustomerValues();

                btnCus.Text = "Add Customer";
                btnCusNew.BackgroundImage = Resource.edit;
                toolTip.SetToolTip(btnCusNew, "Change Existing Customer");
            }
        }

        private void SetExistingCustomerValues()
        {
            if (!IsNew() && cmbCusName.SelectedItem != null)
            {
                Customer customer = (Customer)cmbCusName.SelectedItem;
                List<int> rebateIdList = customer.RebateAgreement.Select(i => i.Id).ToList();

                for (int i = 0; i < chkCusAgreements.Items.Count; i++)
                {
                    Rebate item = (Rebate)chkCusAgreements.Items[i];
                    chkCusAgreements.SetItemChecked(i, rebateIdList.Contains(item.Id));
                }
            }
            else
            {
                for (int i = 0; i < chkCusAgreements.Items.Count; i++)
                {
                    chkCusAgreements.SetItemChecked(i, false);
                }
            }
        }
        private void cmbCusName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetExistingCustomerValues();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            if (InputValidate())
            {
                List<int> rebateIdList = new List<int>();
                for (int i=0;i<chkCusAgreements.Items.Count;i++)
                {
                    if(chkCusAgreements.GetItemChecked(i))
                        rebateIdList.Add(((Rebate)chkCusAgreements.Items[i]).Id);
                }

                try
                {
                    if (IsNew())
                    {
                        string name = txtCusName.Text;

                        engine.AddCustomer(name, rebateIdList);

                        toolStripStatus.Text = "Customer successfully added to the system..";
                        MessageBox.Show("Customer successfully added to the system.", "Price Calculator");
                        
                    }
                    else
                    {
                        int id = ((Customer)cmbCusName.SelectedItem).Id;
                        string name = ((Customer)cmbCusName.SelectedItem).Name;

                        engine.EditCustomer(id, name, rebateIdList);

                        toolStripStatus.Text = "Changes to the customer successfully saved..";
                        MessageBox.Show("Customer successfully changed.", "Price Calculator");
                    }
                    //refresh all
                    onAddCustomerTabSelected();
                }
                catch
                {
                    toolStripStatus.Text = "Error occured while adding the customer to the system..";
                    MessageBox.Show("Unable to add the customer to the system. Please try again later.", "Price Calculator");
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridProduct.Visible = (cmbCategory.SelectedIndex == 0);
            gridRebate.Visible = (cmbCategory.SelectedIndex == 1);
            gridCustomer.Visible = (cmbCategory.SelectedIndex == 2);
        }

        private void grid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView grid = (DataGridView)sender;

                int rowIndex = grid.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    grid.Rows[rowIndex].Selected = true;

                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add(new MenuItem("Delete", delete_Click));
                    m.Show(grid, new Point(e.X, e.Y));
                }

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            int idToDelete;

            if (gridProduct.Visible)
            {
                row = gridProduct.SelectedRows[0];
                idToDelete = (int)row.Cells["Id"].Value;
                try
                {
                    engine.RemoveProduct(idToDelete);
                    toolStripStatus.Text = "Product successfully deleted..";
                    gridProduct.DataSource = GridUtil.GetAllGridProducts(engine.GetAllProducts());
                    gridRebate.DataSource = GridUtil.GetAllGridRebates(engine.GetAllRebates());
                    gridCustomer.DataSource = GridUtil.GetAllGridCustomers(engine.GetAllCustomers());
                }
                catch
                {
                    toolStripStatus.Text = "Error ocurred while deleting the product.."; 
                    MessageBox.Show("Unable to delete the selected product. Please try again!", "Price Calculator");
                }
            }
            else if (gridCustomer.Visible)
            {
                row = gridCustomer.SelectedRows[0];
                idToDelete = (int)row.Cells["Id"].Value;
                try
                {
                    engine.RemoveCustomer(idToDelete);
                    toolStripStatus.Text = "Customer successfully deleted";
                    gridCustomer.DataSource = GridUtil.GetAllGridCustomers(engine.GetAllCustomers());
                }
                catch
                {
                    toolStripStatus.Text = "Error ocurred while deleting the customer..";
                    MessageBox.Show("Unable to delete the selected customer. Please try again!", "Price Calculator");
                }
            }
            else
            {
                row = gridRebate.SelectedRows[0];
                idToDelete = (int)row.Cells["Id"].Value;
                try
                {
                    engine.RemoveRebate(idToDelete);
                    toolStripStatus.Text = "Rebate agreement successfully deleted..";
                    gridRebate.DataSource = GridUtil.GetAllGridRebates(engine.GetAllRebates());
                    gridCustomer.DataSource = GridUtil.GetAllGridCustomers(engine.GetAllCustomers());
                }
                catch
                {
                    toolStripStatus.Text = "Error ocurred while rebate agreement the customer.."; MessageBox.Show("Unable to delete the selected rebate agreement. Please try again!", "Price Calculator");
                }
            }
        }

        #region Helper

        private bool InputValidate()
        {
            toolStripStatus.Text = "Validating inputs..";

            bool isValid = false;
            if (tabMain.SelectedIndex == 0)
            {
                //Validate the calculator tab
                isValid = ValidationUtil.cmb_Validator(cmbCalcCustomer, errorProvider) &&
                    ValidationUtil.cmb_Validator(cmbCalcProduct, errorProvider) &&
                    ValidationUtil.real_Validator(txtCalcQuantity, errorProvider);
            }
            else if (tabMain.SelectedIndex == 1)
            {
                //Validate the product
                isValid = (IsNew() ? ValidationUtil.txt_Validator(txtProdName, errorProvider) : ValidationUtil.cmb_Validator(cmbProdName, errorProvider));
                isValid =  isValid && ValidationUtil.double_Validator(txtProdPrice, errorProvider);
            }
            else if (tabMain.SelectedIndex == 2)
            {
                //Validate the rebate agreement tab
                isValid = (IsNew() ? ValidationUtil.txt_Validator(txtRebName, errorProvider) : ValidationUtil.cmb_Validator(cmbRebName, errorProvider));

                isValid = isValid && ValidationUtil.cmb_Validator(cmbRebProduct, errorProvider) &&
                    ValidationUtil.double_Validator(txtRebDiscount, errorProvider);

                if (isValid && rdbRebVolume.Checked)
                {
                    isValid = isValid && ValidationUtil.real_Validator(txtRebVolQuantity, errorProvider);
                }
                else if (isValid && rdbRebSpecial.Checked)
                {
                    isValid = isValid && ValidationUtil.real_Validator(txtRebSpecialQuantity, errorProvider) &&
                        ValidationUtil.period_Validator(dateRebSpecialStart, dateRebSpecialEnd, errorProvider);
                }
                else
                {
                    isValid = isValid && ValidationUtil.period_Validator(dateRebSeasonalStart, dateRebSeasonalEnd, errorProvider);
                }
            }
            else if (tabMain.SelectedIndex == 3)
            {
                //Validate the customer tab
                isValid = (IsNew() ? ValidationUtil.txt_Validator(txtCusName, errorProvider) : ValidationUtil.cmb_Validator(cmbCusName, errorProvider));
            }

            if(!isValid)
                toolStripStatus.Text = "Field validation error.. Operation aborted..";
            else
                toolStripStatus.Text = "Validation completed..";
            return isValid;
        }

        private bool IsNew()
        {
            bool isNew = false;
            if (tabMain.SelectedIndex == 1)
            {
                isNew = (txtProdName.Visible);
            }
            else if (tabMain.SelectedIndex == 2)
            {
                isNew = (txtRebName.Visible);
            }
            else if (tabMain.SelectedIndex == 3)
            {
                isNew = (txtCusName.Visible);
            }

            return isNew;
        }
        #endregion

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gridRebate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
