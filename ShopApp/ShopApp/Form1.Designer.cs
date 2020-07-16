using System;
using System.Windows.Forms;

namespace ShopApp
{
    partial class shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabDataBase = new System.Windows.Forms.TabControl();
            this.addStudent = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox_Items_ChangeSuppliers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBox_Items_ChangePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Items_ChangeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox_Items_AddSuppliers = new System.Windows.Forms.ComboBox();
            this.btn_Items_AddSave = new System.Windows.Forms.Button();
            this.txtBox_Items_AddPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_Items_AddName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv_Items = new System.Windows.Forms.DataGridView();
            this.Clients = new System.Windows.Forms.TabPage();
            this.Clients_tab = new System.Windows.Forms.TabControl();
            this.Client_Change = new System.Windows.Forms.TabPage();
            this.btn_ClientsDelete = new System.Windows.Forms.Button();
            this.btn_Clients_SearchId = new System.Windows.Forms.Button();
            this.textBox_Clients_AdressChange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Clients_IdChange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Clients_SaveChange = new System.Windows.Forms.Button();
            this.textBox_Clients_TelephoneChange = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Clients_NameChange = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Client_Add = new System.Windows.Forms.TabPage();
            this.textBox_Clients_AddressAdd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Clients_IdAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Client_SaveAdd = new System.Windows.Forms.Button();
            this.textBox_Cliients_TelephoneAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Client_NameAdd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.suppliers = new System.Windows.Forms.TabPage();
            this.Suppliers_tab = new System.Windows.Forms.TabControl();
            this.Suppliers_Change = new System.Windows.Forms.TabPage();
            this.btn_Suppliers_search = new System.Windows.Forms.Button();
            this.txtBox_Suppliers_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SuppliersDelete = new System.Windows.Forms.Button();
            this.btn_Suppliers_SaveChange = new System.Windows.Forms.Button();
            this.textBox_Suppliers_TelChange = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Suppliers_Add = new System.Windows.Forms.TabPage();
            this.btn_Suppliers_SaveAdd = new System.Windows.Forms.Button();
            this.textBox_Suppliers_TelAdd = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_Suppliers_NameAdd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.Orders = new System.Windows.Forms.TabPage();
            this.Order_tab = new System.Windows.Forms.TabControl();
            this.Order_Change = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Order_Add = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.tabDataBase.SuspendLayout();
            this.addStudent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).BeginInit();
            this.Clients.SuspendLayout();
            this.Clients_tab.SuspendLayout();
            this.Client_Change.SuspendLayout();
            this.Client_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.suppliers.SuspendLayout();
            this.Suppliers_tab.SuspendLayout();
            this.Suppliers_Change.SuspendLayout();
            this.Suppliers_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.Orders.SuspendLayout();
            this.Order_tab.SuspendLayout();
            this.Order_Change.SuspendLayout();
            this.Order_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDataBase
            // 
            this.tabDataBase.Controls.Add(this.addStudent);
            this.tabDataBase.Controls.Add(this.Clients);
            this.tabDataBase.Controls.Add(this.suppliers);
            this.tabDataBase.Controls.Add(this.Orders);
            this.tabDataBase.Location = new System.Drawing.Point(12, 12);
            this.tabDataBase.Name = "tabDataBase";
            this.tabDataBase.SelectedIndex = 0;
            this.tabDataBase.Size = new System.Drawing.Size(560, 589);
            this.tabDataBase.TabIndex = 7;
            // 
            // addStudent
            // 
            this.addStudent.Controls.Add(this.tabControl1);
            this.addStudent.Controls.Add(this.dgv_Items);
            this.addStudent.Location = new System.Drawing.Point(4, 22);
            this.addStudent.Name = "addStudent";
            this.addStudent.Padding = new System.Windows.Forms.Padding(3);
            this.addStudent.Size = new System.Drawing.Size(552, 563);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "Items";
            this.addStudent.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 310);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 245);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.comboBox_Items_ChangeSuppliers);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtBox_Items_ChangePrice);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtBox_Items_ChangeName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Change";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(209, 108);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 26;
            this.label26.Text = "Suppliers";
            // 
            // comboBox_Items_ChangeSuppliers
            // 
            this.comboBox_Items_ChangeSuppliers.FormattingEnabled = true;
            this.comboBox_Items_ChangeSuppliers.Location = new System.Drawing.Point(206, 124);
            this.comboBox_Items_ChangeSuppliers.Name = "comboBox_Items_ChangeSuppliers";
            this.comboBox_Items_ChangeSuppliers.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Items_ChangeSuppliers.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 24;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(27, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 55);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(206, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 55);
            this.button3.TabIndex = 14;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtBox_Items_ChangePrice
            // 
            this.txtBox_Items_ChangePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Items_ChangePrice.Location = new System.Drawing.Point(206, 83);
            this.txtBox_Items_ChangePrice.Name = "txtBox_Items_ChangePrice";
            this.txtBox_Items_ChangePrice.Size = new System.Drawing.Size(121, 20);
            this.txtBox_Items_ChangePrice.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // txtBox_Items_ChangeName
            // 
            this.txtBox_Items_ChangeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Items_ChangeName.Location = new System.Drawing.Point(206, 32);
            this.txtBox_Items_ChangeName.Name = "txtBox_Items_ChangeName";
            this.txtBox_Items_ChangeName.Size = new System.Drawing.Size(121, 20);
            this.txtBox_Items_ChangeName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.comboBox_Items_AddSuppliers);
            this.tabPage2.Controls.Add(this.btn_Items_AddSave);
            this.tabPage2.Controls.Add(this.txtBox_Items_AddPrice);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtBox_Items_AddName);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(209, 119);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "Suppliers";
            // 
            // comboBox_Items_AddSuppliers
            // 
            this.comboBox_Items_AddSuppliers.FormattingEnabled = true;
            this.comboBox_Items_AddSuppliers.Location = new System.Drawing.Point(206, 135);
            this.comboBox_Items_AddSuppliers.Name = "comboBox_Items_AddSuppliers";
            this.comboBox_Items_AddSuppliers.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Items_AddSuppliers.TabIndex = 15;
            // 
            // btn_Items_AddSave
            // 
            this.btn_Items_AddSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Items_AddSave.Location = new System.Drawing.Point(206, 180);
            this.btn_Items_AddSave.Name = "btn_Items_AddSave";
            this.btn_Items_AddSave.Size = new System.Drawing.Size(121, 23);
            this.btn_Items_AddSave.TabIndex = 14;
            this.btn_Items_AddSave.Text = "Save";
            this.btn_Items_AddSave.UseVisualStyleBackColor = true;
            this.btn_Items_AddSave.Click += new System.EventHandler(this.btn_Items_AddSave_Click_1);
            // 
            // txtBox_Items_AddPrice
            // 
            this.txtBox_Items_AddPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Items_AddPrice.Location = new System.Drawing.Point(206, 83);
            this.txtBox_Items_AddPrice.Name = "txtBox_Items_AddPrice";
            this.txtBox_Items_AddPrice.Size = new System.Drawing.Size(121, 20);
            this.txtBox_Items_AddPrice.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price";
            // 
            // txtBox_Items_AddName
            // 
            this.txtBox_Items_AddName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Items_AddName.Location = new System.Drawing.Point(206, 32);
            this.txtBox_Items_AddName.Name = "txtBox_Items_AddName";
            this.txtBox_Items_AddName.Size = new System.Drawing.Size(121, 20);
            this.txtBox_Items_AddName.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(209, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Name";
            // 
            // dgv_Items
            // 
            this.dgv_Items.AllowUserToAddRows = false;
            this.dgv_Items.AllowUserToDeleteRows = false;
            this.dgv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Items.Location = new System.Drawing.Point(-4, 0);
            this.dgv_Items.Name = "dgv_Items";
            this.dgv_Items.Size = new System.Drawing.Size(556, 306);
            this.dgv_Items.TabIndex = 5;
            this.dgv_Items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Items_CellContentClick);
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.Clients_tab);
            this.Clients.Controls.Add(this.dgvClients);
            this.Clients.Location = new System.Drawing.Point(4, 22);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(552, 563);
            this.Clients.TabIndex = 1;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // Clients_tab
            // 
            this.Clients_tab.Controls.Add(this.Client_Change);
            this.Clients_tab.Controls.Add(this.Client_Add);
            this.Clients_tab.Location = new System.Drawing.Point(3, 312);
            this.Clients_tab.Name = "Clients_tab";
            this.Clients_tab.SelectedIndex = 0;
            this.Clients_tab.Size = new System.Drawing.Size(540, 245);
            this.Clients_tab.TabIndex = 4;
            // 
            // Client_Change
            // 
            this.Client_Change.Controls.Add(this.btn_ClientsDelete);
            this.Client_Change.Controls.Add(this.btn_Clients_SearchId);
            this.Client_Change.Controls.Add(this.textBox_Clients_AdressChange);
            this.Client_Change.Controls.Add(this.label1);
            this.Client_Change.Controls.Add(this.textBox_Clients_IdChange);
            this.Client_Change.Controls.Add(this.label10);
            this.Client_Change.Controls.Add(this.btn_Clients_SaveChange);
            this.Client_Change.Controls.Add(this.textBox_Clients_TelephoneChange);
            this.Client_Change.Controls.Add(this.label11);
            this.Client_Change.Controls.Add(this.textBox_Clients_NameChange);
            this.Client_Change.Controls.Add(this.label12);
            this.Client_Change.Location = new System.Drawing.Point(4, 22);
            this.Client_Change.Name = "Client_Change";
            this.Client_Change.Padding = new System.Windows.Forms.Padding(3);
            this.Client_Change.Size = new System.Drawing.Size(532, 219);
            this.Client_Change.TabIndex = 0;
            this.Client_Change.Text = "Change";
            this.Client_Change.UseVisualStyleBackColor = true;
            // 
            // btn_ClientsDelete
            // 
            this.btn_ClientsDelete.Location = new System.Drawing.Point(93, 143);
            this.btn_ClientsDelete.Name = "btn_ClientsDelete";
            this.btn_ClientsDelete.Size = new System.Drawing.Size(104, 69);
            this.btn_ClientsDelete.TabIndex = 22;
            this.btn_ClientsDelete.Text = "Delete";
            this.btn_ClientsDelete.UseVisualStyleBackColor = true;
            this.btn_ClientsDelete.Click += new System.EventHandler(this.btn_ClientsDelete_Click);
            // 
            // btn_Clients_SearchId
            // 
            this.btn_Clients_SearchId.Location = new System.Drawing.Point(93, 63);
            this.btn_Clients_SearchId.Name = "btn_Clients_SearchId";
            this.btn_Clients_SearchId.Size = new System.Drawing.Size(75, 23);
            this.btn_Clients_SearchId.TabIndex = 21;
            this.btn_Clients_SearchId.Text = "Search";
            this.btn_Clients_SearchId.UseVisualStyleBackColor = true;
            this.btn_Clients_SearchId.Click += new System.EventHandler(this.btn_Clients_SearchId_Click);
            // 
            // textBox_Clients_AdressChange
            // 
            this.textBox_Clients_AdressChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Clients_AdressChange.Location = new System.Drawing.Point(316, 115);
            this.textBox_Clients_AdressChange.Name = "textBox_Clients_AdressChange";
            this.textBox_Clients_AdressChange.Size = new System.Drawing.Size(121, 20);
            this.textBox_Clients_AdressChange.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adress";
            // 
            // textBox_Clients_IdChange
            // 
            this.textBox_Clients_IdChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Clients_IdChange.Location = new System.Drawing.Point(93, 34);
            this.textBox_Clients_IdChange.Name = "textBox_Clients_IdChange";
            this.textBox_Clients_IdChange.Size = new System.Drawing.Size(121, 20);
            this.textBox_Clients_IdChange.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "ID";
            // 
            // btn_Clients_SaveChange
            // 
            this.btn_Clients_SaveChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clients_SaveChange.Location = new System.Drawing.Point(316, 143);
            this.btn_Clients_SaveChange.Name = "btn_Clients_SaveChange";
            this.btn_Clients_SaveChange.Size = new System.Drawing.Size(121, 69);
            this.btn_Clients_SaveChange.TabIndex = 14;
            this.btn_Clients_SaveChange.Text = "Save";
            this.btn_Clients_SaveChange.UseVisualStyleBackColor = true;
            this.btn_Clients_SaveChange.Click += new System.EventHandler(this.btn_Clients_SaveChange_Click);
            // 
            // textBox_Clients_TelephoneChange
            // 
            this.textBox_Clients_TelephoneChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Clients_TelephoneChange.Location = new System.Drawing.Point(316, 66);
            this.textBox_Clients_TelephoneChange.Name = "textBox_Clients_TelephoneChange";
            this.textBox_Clients_TelephoneChange.Size = new System.Drawing.Size(121, 20);
            this.textBox_Clients_TelephoneChange.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Telephone";
            // 
            // textBox_Clients_NameChange
            // 
            this.textBox_Clients_NameChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Clients_NameChange.Location = new System.Drawing.Point(316, 20);
            this.textBox_Clients_NameChange.Name = "textBox_Clients_NameChange";
            this.textBox_Clients_NameChange.Size = new System.Drawing.Size(121, 20);
            this.textBox_Clients_NameChange.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(319, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Name";
            // 
            // Client_Add
            // 
            this.Client_Add.Controls.Add(this.textBox_Clients_AddressAdd);
            this.Client_Add.Controls.Add(this.label13);
            this.Client_Add.Controls.Add(this.textBox_Clients_IdAdd);
            this.Client_Add.Controls.Add(this.label7);
            this.Client_Add.Controls.Add(this.btn_Client_SaveAdd);
            this.Client_Add.Controls.Add(this.textBox_Cliients_TelephoneAdd);
            this.Client_Add.Controls.Add(this.label8);
            this.Client_Add.Controls.Add(this.textBox_Client_NameAdd);
            this.Client_Add.Controls.Add(this.label9);
            this.Client_Add.Location = new System.Drawing.Point(4, 22);
            this.Client_Add.Name = "Client_Add";
            this.Client_Add.Padding = new System.Windows.Forms.Padding(3);
            this.Client_Add.Size = new System.Drawing.Size(532, 219);
            this.Client_Add.TabIndex = 1;
            this.Client_Add.Text = "Add";
            this.Client_Add.UseVisualStyleBackColor = true;
            this.Client_Add.Click += new System.EventHandler(this.Client_Add_Click);
            // 
            // textBox_Clients_AddressAdd
            // 
            this.textBox_Clients_AddressAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Clients_AddressAdd.Location = new System.Drawing.Point(206, 154);
            this.textBox_Clients_AddressAdd.Name = "textBox_Clients_AddressAdd";
            this.textBox_Clients_AddressAdd.Size = new System.Drawing.Size(121, 20);
            this.textBox_Clients_AddressAdd.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(208, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Address";
            // 
            // textBox_Clients_IdAdd
            // 
            this.textBox_Clients_IdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Clients_IdAdd.Location = new System.Drawing.Point(207, 111);
            this.textBox_Clients_IdAdd.Name = "textBox_Clients_IdAdd";
            this.textBox_Clients_IdAdd.Size = new System.Drawing.Size(121, 20);
            this.textBox_Clients_IdAdd.TabIndex = 16;
            this.textBox_Clients_IdAdd.TextChanged += new System.EventHandler(this.textBox_Clients_IdAdd_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID";
            // 
            // btn_Client_SaveAdd
            // 
            this.btn_Client_SaveAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Client_SaveAdd.Location = new System.Drawing.Point(206, 180);
            this.btn_Client_SaveAdd.Name = "btn_Client_SaveAdd";
            this.btn_Client_SaveAdd.Size = new System.Drawing.Size(121, 23);
            this.btn_Client_SaveAdd.TabIndex = 14;
            this.btn_Client_SaveAdd.Text = "Save";
            this.btn_Client_SaveAdd.UseVisualStyleBackColor = true;
            this.btn_Client_SaveAdd.Click += new System.EventHandler(this.btn_Client_SaveAdd_Click);
            // 
            // textBox_Cliients_TelephoneAdd
            // 
            this.textBox_Cliients_TelephoneAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Cliients_TelephoneAdd.Location = new System.Drawing.Point(207, 69);
            this.textBox_Cliients_TelephoneAdd.Name = "textBox_Cliients_TelephoneAdd";
            this.textBox_Cliients_TelephoneAdd.Size = new System.Drawing.Size(121, 20);
            this.textBox_Cliients_TelephoneAdd.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Telephone";
            // 
            // textBox_Client_NameAdd
            // 
            this.textBox_Client_NameAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Client_NameAdd.Location = new System.Drawing.Point(208, 20);
            this.textBox_Client_NameAdd.Name = "textBox_Client_NameAdd";
            this.textBox_Client_NameAdd.Size = new System.Drawing.Size(121, 20);
            this.textBox_Client_NameAdd.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Name";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(-4, 0);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(556, 306);
            this.dgvClients.TabIndex = 1;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // suppliers
            // 
            this.suppliers.Controls.Add(this.Suppliers_tab);
            this.suppliers.Controls.Add(this.dgvSuppliers);
            this.suppliers.Location = new System.Drawing.Point(4, 22);
            this.suppliers.Name = "suppliers";
            this.suppliers.Padding = new System.Windows.Forms.Padding(3);
            this.suppliers.Size = new System.Drawing.Size(552, 563);
            this.suppliers.TabIndex = 2;
            this.suppliers.Text = "Suppliers";
            this.suppliers.UseVisualStyleBackColor = true;
            // 
            // Suppliers_tab
            // 
            this.Suppliers_tab.Controls.Add(this.Suppliers_Change);
            this.Suppliers_tab.Controls.Add(this.Suppliers_Add);
            this.Suppliers_tab.Location = new System.Drawing.Point(3, 312);
            this.Suppliers_tab.Name = "Suppliers_tab";
            this.Suppliers_tab.SelectedIndex = 0;
            this.Suppliers_tab.Size = new System.Drawing.Size(540, 245);
            this.Suppliers_tab.TabIndex = 4;
            // 
            // Suppliers_Change
            // 
            this.Suppliers_Change.Controls.Add(this.btn_Suppliers_search);
            this.Suppliers_Change.Controls.Add(this.txtBox_Suppliers_search);
            this.Suppliers_Change.Controls.Add(this.label2);
            this.Suppliers_Change.Controls.Add(this.btn_SuppliersDelete);
            this.Suppliers_Change.Controls.Add(this.btn_Suppliers_SaveChange);
            this.Suppliers_Change.Controls.Add(this.textBox_Suppliers_TelChange);
            this.Suppliers_Change.Controls.Add(this.label14);
            this.Suppliers_Change.Location = new System.Drawing.Point(4, 22);
            this.Suppliers_Change.Name = "Suppliers_Change";
            this.Suppliers_Change.Padding = new System.Windows.Forms.Padding(3);
            this.Suppliers_Change.Size = new System.Drawing.Size(532, 219);
            this.Suppliers_Change.TabIndex = 0;
            this.Suppliers_Change.Text = "Change";
            this.Suppliers_Change.UseVisualStyleBackColor = true;
            // 
            // btn_Suppliers_search
            // 
            this.btn_Suppliers_search.Location = new System.Drawing.Point(27, 148);
            this.btn_Suppliers_search.Name = "btn_Suppliers_search";
            this.btn_Suppliers_search.Size = new System.Drawing.Size(121, 55);
            this.btn_Suppliers_search.TabIndex = 24;
            this.btn_Suppliers_search.Text = "Search";
            this.btn_Suppliers_search.UseVisualStyleBackColor = true;
            this.btn_Suppliers_search.Click += new System.EventHandler(this.btn_Suppliers_search_Click_1);
            // 
            // txtBox_Suppliers_search
            // 
            this.txtBox_Suppliers_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Suppliers_search.Location = new System.Drawing.Point(27, 83);
            this.txtBox_Suppliers_search.Name = "txtBox_Suppliers_search";
            this.txtBox_Suppliers_search.Size = new System.Drawing.Size(121, 20);
            this.txtBox_Suppliers_search.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name of company";
            // 
            // btn_SuppliersDelete
            // 
            this.btn_SuppliersDelete.Location = new System.Drawing.Point(381, 148);
            this.btn_SuppliersDelete.Name = "btn_SuppliersDelete";
            this.btn_SuppliersDelete.Size = new System.Drawing.Size(123, 55);
            this.btn_SuppliersDelete.TabIndex = 15;
            this.btn_SuppliersDelete.Text = "Delete";
            this.btn_SuppliersDelete.UseVisualStyleBackColor = true;
            this.btn_SuppliersDelete.Click += new System.EventHandler(this.btn_SuppliersDelete_Click);
            // 
            // btn_Suppliers_SaveChange
            // 
            this.btn_Suppliers_SaveChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Suppliers_SaveChange.Location = new System.Drawing.Point(206, 148);
            this.btn_Suppliers_SaveChange.Name = "btn_Suppliers_SaveChange";
            this.btn_Suppliers_SaveChange.Size = new System.Drawing.Size(121, 55);
            this.btn_Suppliers_SaveChange.TabIndex = 14;
            this.btn_Suppliers_SaveChange.Text = "Save";
            this.btn_Suppliers_SaveChange.UseVisualStyleBackColor = true;
            this.btn_Suppliers_SaveChange.Click += new System.EventHandler(this.btn_Suppliers_SaveChange_Click);
            // 
            // textBox_Suppliers_TelChange
            // 
            this.textBox_Suppliers_TelChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Suppliers_TelChange.Location = new System.Drawing.Point(206, 83);
            this.textBox_Suppliers_TelChange.Name = "textBox_Suppliers_TelChange";
            this.textBox_Suppliers_TelChange.Size = new System.Drawing.Size(121, 20);
            this.textBox_Suppliers_TelChange.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(209, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Telephone";
            // 
            // Suppliers_Add
            // 
            this.Suppliers_Add.Controls.Add(this.btn_Suppliers_SaveAdd);
            this.Suppliers_Add.Controls.Add(this.textBox_Suppliers_TelAdd);
            this.Suppliers_Add.Controls.Add(this.label17);
            this.Suppliers_Add.Controls.Add(this.textBox_Suppliers_NameAdd);
            this.Suppliers_Add.Controls.Add(this.label18);
            this.Suppliers_Add.Location = new System.Drawing.Point(4, 22);
            this.Suppliers_Add.Name = "Suppliers_Add";
            this.Suppliers_Add.Padding = new System.Windows.Forms.Padding(3);
            this.Suppliers_Add.Size = new System.Drawing.Size(532, 219);
            this.Suppliers_Add.TabIndex = 1;
            this.Suppliers_Add.Text = "Add";
            this.Suppliers_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Suppliers_SaveAdd
            // 
            this.btn_Suppliers_SaveAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Suppliers_SaveAdd.Location = new System.Drawing.Point(206, 180);
            this.btn_Suppliers_SaveAdd.Name = "btn_Suppliers_SaveAdd";
            this.btn_Suppliers_SaveAdd.Size = new System.Drawing.Size(121, 23);
            this.btn_Suppliers_SaveAdd.TabIndex = 14;
            this.btn_Suppliers_SaveAdd.Text = "Save";
            this.btn_Suppliers_SaveAdd.UseVisualStyleBackColor = true;
            this.btn_Suppliers_SaveAdd.Click += new System.EventHandler(this.btn_Suppliers_SaveAdd_Click);
            // 
            // textBox_Suppliers_TelAdd
            // 
            this.textBox_Suppliers_TelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Suppliers_TelAdd.Location = new System.Drawing.Point(206, 83);
            this.textBox_Suppliers_TelAdd.Name = "textBox_Suppliers_TelAdd";
            this.textBox_Suppliers_TelAdd.Size = new System.Drawing.Size(121, 20);
            this.textBox_Suppliers_TelAdd.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(209, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Telephone";
            // 
            // textBox_Suppliers_NameAdd
            // 
            this.textBox_Suppliers_NameAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Suppliers_NameAdd.Location = new System.Drawing.Point(206, 32);
            this.textBox_Suppliers_NameAdd.Name = "textBox_Suppliers_NameAdd";
            this.textBox_Suppliers_NameAdd.Size = new System.Drawing.Size(121, 20);
            this.textBox_Suppliers_NameAdd.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(209, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Name";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(-4, 0);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.Size = new System.Drawing.Size(560, 306);
            this.dgvSuppliers.TabIndex = 1;
            this.dgvSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.Order_tab);
            this.Orders.Controls.Add(this.dgv_Orders);
            this.Orders.Location = new System.Drawing.Point(4, 22);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(552, 563);
            this.Orders.TabIndex = 3;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // Order_tab
            // 
            this.Order_tab.Controls.Add(this.Order_Change);
            this.Order_tab.Controls.Add(this.Order_Add);
            this.Order_tab.Location = new System.Drawing.Point(3, 312);
            this.Order_tab.Name = "Order_tab";
            this.Order_tab.SelectedIndex = 0;
            this.Order_tab.Size = new System.Drawing.Size(540, 245);
            this.Order_tab.TabIndex = 3;
            // 
            // Order_Change
            // 
            this.Order_Change.Controls.Add(this.button5);
            this.Order_Change.Controls.Add(this.comboBox5);
            this.Order_Change.Controls.Add(this.label19);
            this.Order_Change.Controls.Add(this.textBox9);
            this.Order_Change.Controls.Add(this.label20);
            this.Order_Change.Controls.Add(this.textBox10);
            this.Order_Change.Controls.Add(this.label21);
            this.Order_Change.Location = new System.Drawing.Point(4, 22);
            this.Order_Change.Name = "Order_Change";
            this.Order_Change.Padding = new System.Windows.Forms.Padding(3);
            this.Order_Change.Size = new System.Drawing.Size(532, 219);
            this.Order_Change.TabIndex = 0;
            this.Order_Change.Text = "Change";
            this.Order_Change.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(206, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(206, 135);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(209, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Supplier";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Location = new System.Drawing.Point(206, 83);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(121, 20);
            this.textBox9.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(209, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Price";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Location = new System.Drawing.Point(206, 32);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(121, 20);
            this.textBox10.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(209, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Name";
            // 
            // Order_Add
            // 
            this.Order_Add.Controls.Add(this.button6);
            this.Order_Add.Controls.Add(this.comboBox6);
            this.Order_Add.Controls.Add(this.label22);
            this.Order_Add.Controls.Add(this.textBox11);
            this.Order_Add.Controls.Add(this.label23);
            this.Order_Add.Controls.Add(this.textBox12);
            this.Order_Add.Controls.Add(this.label24);
            this.Order_Add.Location = new System.Drawing.Point(4, 22);
            this.Order_Add.Name = "Order_Add";
            this.Order_Add.Padding = new System.Windows.Forms.Padding(3);
            this.Order_Add.Size = new System.Drawing.Size(532, 219);
            this.Order_Add.TabIndex = 1;
            this.Order_Add.Text = "Add";
            this.Order_Add.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(206, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(206, 135);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(209, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Supplier";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Location = new System.Drawing.Point(206, 83);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(121, 20);
            this.textBox11.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(209, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Price";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Location = new System.Drawing.Point(206, 32);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(121, 20);
            this.textBox12.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(209, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "Name";
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.Location = new System.Drawing.Point(-4, 0);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.Size = new System.Drawing.Size(560, 306);
            this.dgv_Orders.TabIndex = 2;
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 629);
            this.Controls.Add(this.tabDataBase);
            this.Name = "shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.shop_Load);
            this.tabDataBase.ResumeLayout(false);
            this.addStudent.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).EndInit();
            this.Clients.ResumeLayout(false);
            this.Clients_tab.ResumeLayout(false);
            this.Client_Change.ResumeLayout(false);
            this.Client_Change.PerformLayout();
            this.Client_Add.ResumeLayout(false);
            this.Client_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.suppliers.ResumeLayout(false);
            this.Suppliers_tab.ResumeLayout(false);
            this.Suppliers_Change.ResumeLayout(false);
            this.Suppliers_Change.PerformLayout();
            this.Suppliers_Add.ResumeLayout(false);
            this.Suppliers_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.Orders.ResumeLayout(false);
            this.Order_tab.ResumeLayout(false);
            this.Order_Change.ResumeLayout(false);
            this.Order_Change.PerformLayout();
            this.Order_Add.ResumeLayout(false);
            this.Order_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            this.ResumeLayout(false);

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Client_Add_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Item_Add_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dgv_Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabDataBase;
        private System.Windows.Forms.TabPage addStudent;
        private System.Windows.Forms.TabPage Clients;
        private ShopApp.dbShopDataSet dbShopDataSet;
        private System.Windows.Forms.TabPage suppliers;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.TabControl Clients_tab;
        private System.Windows.Forms.TabPage Client_Change;
        private System.Windows.Forms.TabPage Client_Add;
        private System.Windows.Forms.TabControl Suppliers_tab;
        private System.Windows.Forms.TabPage Suppliers_Change;
        private System.Windows.Forms.TabPage Suppliers_Add;
        private System.Windows.Forms.TabControl Order_tab;
        private System.Windows.Forms.TabPage Order_Change;
        private System.Windows.Forms.TabPage Order_Add;
        private System.Windows.Forms.DataGridView dgv_Items;
        private System.Windows.Forms.Button btn_Clients_SaveChange;
        private System.Windows.Forms.TextBox textBox_Clients_TelephoneChange;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Clients_NameChange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Client_SaveAdd;
        private System.Windows.Forms.TextBox textBox_Cliients_TelephoneAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Client_NameAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Suppliers_SaveChange;
        private System.Windows.Forms.TextBox textBox_Suppliers_TelChange;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Suppliers_SaveAdd;
        private System.Windows.Forms.TextBox textBox_Suppliers_TelAdd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_Suppliers_NameAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_Clients_IdChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Clients_IdAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Clients_AddressAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Clients_AdressChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Clients_SearchId;
        private System.Windows.Forms.Button btn_ClientsDelete;
        private Button btn_SuppliersDelete;
        private Button btn_Suppliers_search;
        private TextBox txtBox_Suppliers_search;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label26;
        private ComboBox comboBox_Items_ChangeSuppliers;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Button button2;
        private Button button3;
        private TextBox txtBox_Items_ChangePrice;
        private Label label4;
        private TextBox txtBox_Items_ChangeName;
        private Label label5;
        private TabPage tabPage2;
        private Label label25;
        private ComboBox comboBox_Items_AddSuppliers;
        private Button btn_Items_AddSave;
        private TextBox txtBox_Items_AddPrice;
        private Label label6;
        private TextBox txtBox_Items_AddName;
        private Label label16;
    }

    internal class dbShopDataSetTableAdapters
    {
    }

    internal class dbShopDataSet
    {
        public dbShopDataSet()
        {
        }
    }
}

