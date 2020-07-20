using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class shop : Form
    {
        private DBSQL dataB;
        private int id_item;
        private int id_client;
        private List<Item> items_list;
        private float sumOrder;

        public shop()
        {
            InitializeComponent();

        }
    
        private void shop_Load(object sender, EventArgs e)
        {            
            sumOrder = 0;
            items_list = new List<Item>();
            string dbPath = Application.StartupPath + @"\..\..\dbShop(Access).accdb";
            if (File.Exists(dbPath))
            {
                DBSQL.ConnectionString = dbPath;
                dataB = DBSQL.Instance;

            }
            else
            {
                MessageBox.Show("DataBase" + dbPath + " not found");
                Application.Exit();
            }

            ShowClientsDgv();
            ShowSuppliersDgv();
            ShowItemsDgv();
            ShowOrdersAllDgv();
            
            fillSuppliers();

            //Colors for buttons
            btn_ClientsDelete.BackColor = Color.IndianRed;
            btn_items_delete.BackColor = Color.IndianRed;
            btn_SuppliersDelete.BackColor = Color.IndianRed;
            btn_Clients_SaveChange.BackColor = Color.LightYellow;
            btn_Client_SaveAdd.BackColor = Color.LightYellow;
            btn_Suppliers_SaveAdd.BackColor = Color.LightYellow;
            btn_Suppliers_SaveChange.BackColor = Color.LightYellow;
            btn_Items_AddSave.BackColor = Color.LightYellow;
            btn_items_changeSave.BackColor = Color.LightYellow;
            btn_Clients_SearchId.BackColor = Color.LightSeaGreen;
            btn_items_search.BackColor = Color.LightSeaGreen;
            btn_Suppliers_search.BackColor = Color.LightSeaGreen;

        }

        private void btn_Client_SaveAdd_Click(object sender, EventArgs e)
        {           
            if (textBox_Clients_IdAdd.Text != "" && textBox_Client_NameAdd.Text != "" && textBox_Clients_AddressAdd.Text != "" 
                && textBox_Cliients_TelephoneAdd.Text != "")
            {
                try
                {
                    Client person = new Client();
                    person.GetSetId = int.Parse(textBox_Clients_IdAdd.Text);
                    person.GetSetName = textBox_Client_NameAdd.Text;
                    person.GetSetTel = textBox_Cliients_TelephoneAdd.Text;
                    person.GetSetAddress = textBox_Clients_AddressAdd.Text;
                    dataB.InsertClient(person);
                    MessageBox.Show("DataBase added:\nName: " + person.GetSetName.ToString() + "\nAddress: " + person.GetSetAddress.ToString()
                        + "\nTelephone: " + person.GetSetTel.ToString() + "\n");
                    ShowClientsDgv();
                }
                catch (Exception ex) {MessageBox.Show(ex.Message);}
            }
            else
            {
                MessageBox.Show("Need to fill in all fields");
            }
        }

        private void textBox_Clients_IdAdd_TextChanged(object sender, EventArgs e)
        {

        }
        //
        //Button saves changes in db and table and show message
        //
        private void btn_Clients_SaveChange_Click(object sender, EventArgs e)
        {
            if (textBox_Clients_NameChange.Text != "" && textBox_Clients_AdressChange.Text != ""
                && textBox_Clients_AdressChange.Text != "")
            {
                Client person = new Client();
                person.GetSetId = int.Parse(textBox_Clients_IdChange.Text);
                person.GetSetName = textBox_Clients_NameChange.Text;
                person.GetSetTel = textBox_Clients_TelephoneChange.Text;
                person.GetSetAddress = textBox_Clients_AdressChange.Text;
                dataB.UpdateClient(person);
                ShowClientsDgv();
                MessageBox.Show("DataBase changed:\nName: " + person.GetSetName.ToString() + "\nAddress: " + person.GetSetAddress.ToString()
                    + "\nTelephone: " + person.GetSetTel.ToString() + "\n");
            }
            else
            {
                MessageBox.Show("Need to fill in all fields");
            }
        }

        //show table with all Clients in db
        private void ShowClientsDgv()
        {
            Client[] clients = dataB.GetClientsData();//array of clients from db
            dgvClients.DataSource = clients;
            dgvClients.Columns[0].HeaderText = "id";//Titles
            dgvClients.Columns[1].HeaderText = "Name";
            dgvClients.Columns[2].HeaderText = "Telephone";
            dgvClients.Columns[3].HeaderText = "Adress";
        }

        //show table with all Suppliers in db
        private void ShowSuppliersDgv()
        {

            Suppliers[] firms = dataB.GetSuppliersData();//array of suppliers from db
            dgvSuppliers.DataSource = firms;
            dgvSuppliers.Columns[0].HeaderText = "Name";
            dgvSuppliers.Columns[1].HeaderText = "Telephone";
            
        }

        //show table with all Suppliers in db
        private void ShowItemsDgv()
        {
            Item[] items = dataB.GetItemsData();//array of suppliers from db
            dgv_Items.DataSource = items;
            dgv_Items.Columns[0].HeaderText = "№";
            dgv_Items.Columns[1].HeaderText = "Name";
            dgv_Items.Columns[2].HeaderText = "Price";
            dgv_Items.Columns[3].HeaderText = "Suppliers";

        }

        private void ShowOrderDgv()
        {
            Item[] items_array = items_list.ToArray();
            dgv_orders_addNewOrder.ColumnCount = 4; //number of Columns
            dgv_orders_addNewOrder.RowCount = items_array.Length;//number of Rows

            dgv_orders_addNewOrder.Columns[0].HeaderText = "№";
            dgv_orders_addNewOrder.Columns[1].HeaderText = "Name of Item";
            dgv_orders_addNewOrder.Columns[2].HeaderText = "Price";
            dgv_orders_addNewOrder.Columns[3].HeaderText = "Buyer";

            for (int i = 0; i<items_array.Length; i++)//set data in cells
            {
                dgv_orders_addNewOrder[0, i].Value = items_array[i].GetSetId;
                dgv_orders_addNewOrder[1, i].Value = items_array[i].GetSetItem;
                dgv_orders_addNewOrder[2, i].Value = items_array[i].GetSetPrice;
                dgv_orders_addNewOrder[3, i].Value = id_client;
            }
        }

        private void ShowOrdersAllDgv()
        {
          
            Order[] orders = dataB.GetOrdersData();//array of suppliers from db
            dgv_Orders_All.DataSource = orders;
            dgv_Orders_All.Columns[0].HeaderText = "Order №";
            dgv_Orders_All.Columns[1].HeaderText = "ID Client";
            dgv_Orders_All.Columns[2].HeaderText = "ID Item";
            dgv_Orders_All.Columns[3].HeaderText = "Delivery status";
            

        }

        private void btn_Clients_SearchId_Click(object sender, EventArgs e)
        {
            string searchValue = textBox_Clients_IdChange.Text;
            dgvClients.ClearSelection();
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvClients.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        textBox_Clients_NameChange.Text = row.Cells[1].Value.ToString();
                        textBox_Clients_TelephoneChange.Text = row.Cells[2].Value.ToString();
                        textBox_Clients_AdressChange.Text = row.Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btn_ClientsDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvClients.SelectedRows)
            {
                dgvClients.Rows.RemoveAt(item.Index);
                dataB.DeleteRowClients(int.Parse(item.Cells[0].Value.ToString()));
            }
        }

        private void btn_Suppliers_SaveAdd_Click(object sender, EventArgs e)
        {
            if (textBox_Suppliers_NameAdd.Text != "" && textBox_Suppliers_TelAdd.Text != "" )
            {
                try
                {
                    Suppliers firm = new Suppliers();
                    firm.GetSetNameCompany = textBox_Suppliers_NameAdd.Text;
                    firm.GetSetTel = textBox_Suppliers_TelAdd.Text;
                    dataB.InsertFirm(firm);
                    MessageBox.Show("DataBase added:\nName: " + firm.GetSetNameCompany.ToString());
                    ShowSuppliersDgv();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Need to fill in all fields");
            }
            fillSuppliers();
        }

        private void btn_SuppliersDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvSuppliers.SelectedRows)
            {
                dgvSuppliers.Rows.RemoveAt(item.Index);
                dataB.DeleteRowSuppliers(item.Cells[0].Value.ToString());
                dataB.DeleteRowItems(item.Cells[0].Value.ToString());
            }
            ShowItemsDgv();
            fillSuppliers();
        }



        private void btn_Suppliers_SaveChange_Click(object sender, EventArgs e)
        {
            if (textBox_Suppliers_TelChange.Text != "")
            {
                Suppliers firm = new Suppliers();
                firm.GetSetNameCompany = txtBox_Suppliers_search.Text;
                firm.GetSetTel = textBox_Suppliers_TelChange.Text;
                dataB.UpdateFirm(firm);
                MessageBox.Show("DataBase changed:\nName: " + firm.GetSetNameCompany.ToString() + "\nTelephone" + firm.GetSetTel.ToString());
                ShowSuppliersDgv();
            }
            else
            {
                MessageBox.Show("Need to fill in all fields");
            }
            fillSuppliers();
        }


        private void btn_Suppliers_search_Click_1(object sender, EventArgs e)
        {
            string searchValue = txtBox_Suppliers_search.Text;
            dgvSuppliers.ClearSelection();
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvSuppliers.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue)) //|| row.Cells[2].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        textBox_Suppliers_TelChange.Text = row.Cells[1].Value.ToString();
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_Items_AddSave_Click(object sender, EventArgs e)
        {
            if (txtBox_Items_AddName.Text != "" && txtBox_Items_AddPrice.Text != "")
            {
                try
                {
                    Item item = new Item();
                    
                    item.GetSetItem = txtBox_Items_AddName.Text;
                    item.GetSetPrice = float.Parse(txtBox_Items_AddPrice.Text);
                    item.GetSetSupplier = comboBox_Items_AddSuppliers.Text;
                    dataB.InsertItem(item);
                    MessageBox.Show("DataBase added");
                    ShowItemsDgv();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Need to fill in all fields");
            }
        }

        private void fillSuppliers()
        {
            Suppliers[] firms = dataB.GetSuppliersData();
            comboBox_Items_AddSuppliers.Items.Clear();
            comboBox_Items_ChangeSuppliers.Items.Clear();
            for (int i = 0; i < firms.Length; i++)
            {
                comboBox_Items_AddSuppliers.Items.Add(firms[i].GetSetNameCompany);
                comboBox_Items_ChangeSuppliers.Items.Add(firms[i].GetSetNameCompany);
            }
        }

        private void btn_Items_AddSave_Click_1(object sender, EventArgs e)
        {
            if (txtBox_Items_AddName.Text != "" && txtBox_Items_AddPrice.Text != "")
            {
                try
                {
                    Item item = new Item();

                    item.GetSetItem = txtBox_Items_AddName.Text;
                    item.GetSetPrice = float.Parse(txtBox_Items_AddPrice.Text);
                    item.GetSetSupplier = comboBox_Items_AddSuppliers.Text;
                    dataB.InsertItem(item);
                    MessageBox.Show("DataBase added");
                    ShowItemsDgv();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Need to fill in all fields");
            }
        }

        private void btn_items_search_Click(object sender, EventArgs e)
        {
            string searchValue = txtBox_items_search.Text;
            dgv_Items.ClearSelection();
            dgv_Items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgv_Items.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))//search the same name of item and pull all information into textBox
                    {
                        row.Selected = true;
                        id_item = int.Parse(row.Cells[0].Value.ToString());
                        txtBox_Items_ChangeName.Text = row.Cells[1].Value.ToString();
                        txtBox_Items_ChangePrice.Text = row.Cells[2].Value.ToString();
                        comboBox_Items_ChangeSuppliers.Text = row.Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_items_changeSave_Click(object sender, EventArgs e)
        {
            if (txtBox_Items_ChangeName.Text != "" && txtBox_Items_ChangePrice.Text != "")                
            {
                Item item = new Item();
                item.GetSetId = id_item;
                item.GetSetItem = txtBox_Items_ChangeName.Text;
                item.GetSetPrice = float.Parse(txtBox_Items_ChangePrice.Text);
                item.GetSetSupplier = comboBox_Items_ChangeSuppliers.Text;
                dataB.UpdateItem(item);
                ShowItemsDgv();
                MessageBox.Show("DataBase changed:\nName: " + item.GetSetItem.ToString() + "\nPriice: " + item.GetSetPrice.ToString()
                    + "\nSupplier: " + item.GetSetSupplier.ToString() + "\n");
            }
            else
            {
                MessageBox.Show("Need to fill in all fields");
            }
        }

        private void btn_items_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgv_Items.SelectedRows)
            {
                dgv_Items.Rows.RemoveAt(item.Index);
                dataB.DeleteRowItems(int.Parse(item.Cells[0].Value.ToString()));                
            }
        }

        //button for submit client for order
        private void btn_Clients_order_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow client in this.dgvClients.SelectedRows)
            {
                id_client=int.Parse(client.Cells[0].Value.ToString());
            }
            ShowOrderDgv();//if was choosed before we change it
        }

        //add to arraay list name of item which was added to cart
        private void btn_Items_addToCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item_row in this.dgv_Items.SelectedRows)
            {
                Item item_selected = new Item();
                item_selected.GetSetId = int.Parse(item_row.Cells[0].Value.ToString());
                item_selected.GetSetItem = item_row.Cells[1].Value.ToString();
                item_selected.GetSetPrice = float.Parse(item_row.Cells[2].Value.ToString());
                item_selected.GetSetSupplier = item_row.Cells[0].Value.ToString();
                items_list.Add(item_selected);
                sumOrder += item_selected.GetSetPrice;
            }
            lbl_Orders_Summary.Text = sumOrder.ToString();
            ShowOrderDgv();
        }

        private void btn_Orders_Add_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item_row in this.dgv_orders_addNewOrder.SelectedRows)
            {               
                sumOrder-= float.Parse(item_row.Cells[2].Value.ToString());
                items_list.RemoveAt(item_row.Index);
                dgv_orders_addNewOrder.Rows.RemoveAt(item_row.Index);
                lbl_Orders_Summary.Text = sumOrder.ToString();
            }
        }

        private void btn_Orders__Add_Save_Click(object sender, EventArgs e)
        {
            Item [] item_arr = items_list.ToArray();
            foreach (DataGridViewRow order_row in this.dgv_orders_addNewOrder.Rows)
            {
                Order order = new Order();
                order.GetSetIdClient = id_client;
                order.GetSetIdItem = item_arr[order_row.Index].GetSetId;
                order.GetSetDelivered = false;                
                dataB.InsertOrder(order);
            }
            ShowOrdersAllDgv();
            
        }

        private void btn_Orders_ShowName_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow order_row in this.dgv_Orders_All.SelectedRows)
            {
                int id = int.Parse(order_row.Cells[3].Value.ToString());
            }
            MessageBox.Show("Need to fill in all fields");
        }
    }
}
