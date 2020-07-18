using System;
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

        public shop()
        {
            InitializeComponent();

        }
    
        private void shop_Load(object sender, EventArgs e)
        {
        
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
            fillSuppliers();

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
                && textBox_Cliients_TelephoneAdd.Text != "")
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
            int numOfStu = dataB.GetClientNumber();//number of Rows
          
            dgvClients.ColumnCount = 4;//number of Columns
            dgvClients.RowCount = numOfStu;//number of Rows

            dgvClients.Columns[0].HeaderText = "id";//Titles
            dgvClients.Columns[1].HeaderText = "Name";
            dgvClients.Columns[2].HeaderText = "Telephone";
            dgvClients.Columns[3].HeaderText = "Adress";

            Client[] clients = dataB.GetClientsData();//array of clients from db
            for (int i = 0; i < numOfStu; i++)//set data in cells
            {
                dgvClients[0, i].Value = clients[i].GetSetId;
                dgvClients[1, i].Value = clients[i].GetSetName;
                dgvClients[2, i].Value = clients[i].GetSetTel;
                dgvClients[3, i].Value = clients[i].GetSetAddress;
            }           
        }

        //show table with all Suppliers in db
        private void ShowSuppliersDgv()
        {
            int numOfStu = dataB.GetSuppliersNumber();//number of Rows

            dgvSuppliers.ColumnCount = 2;//number of Columns
            dgvSuppliers.RowCount = numOfStu;//number of Rows

            //dgvSuppliers.Columns[0].HeaderText = "id";//Titles
            dgvSuppliers.Columns[0].HeaderText = "Name";
            dgvSuppliers.Columns[1].HeaderText = "Telephone";
            

            Suppliers[] firms = dataB.GetSuppliersData();//array of suppliers from db
            for (int i = 0; i < numOfStu; i++)//set data in cells
            {
                //dgvSuppliers[0, i].Value = firms[i].GetSetIdSupplier;
                dgvSuppliers[0, i].Value = firms[i].GetSetNameCompany;
                dgvSuppliers[1, i].Value = firms[i].GetSetTel;
                
            }
        }

        //show table with all Suppliers in db
        private void ShowItemsDgv()
        {
            int numOfStu = dataB.GetItemsNumber();//number of Rows

            dgv_Items.ColumnCount = 4;//number of Columns
            dgv_Items.RowCount = numOfStu;//number of Rows

            dgv_Items.Columns[0].HeaderText = "№";
            dgv_Items.Columns[1].HeaderText = "Name";
            dgv_Items.Columns[2].HeaderText = "Price";
            dgv_Items.Columns[3].HeaderText = "Suppliers";


            Item[] items = dataB.GetItemsData();//array of suppliers from db
            for (int i = 0; i < numOfStu; i++)//set data in cells
            {
                dgv_Items[0, i].Value = items[i].GetSetId;
                dgv_Items[1, i].Value = items[i].GetSetItem;
                dgv_Items[2, i].Value = items[i].GetSetPrice;
                dgv_Items[3, i].Value = items[i].GetSetSupplier;
            }
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
    }
}
