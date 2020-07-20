using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class DBSQL : DbAccess
    {
        private static string conString;
        private static DBSQL instacne;

        public DBSQL(string connectionString) : base(connectionString)
        {
        }

        public static DBSQL Instance
        {
            get
            {
                if (instacne == null)
                {
                    instacne = new DBSQL(conString);
                }
                return instacne;
            }

        }

        public static string ConnectionString
        {
            get { return conString; }
            set
            {
                conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + value + ";Persist Security Info=False;";
            }
        }


        //Insert to customer table
        public void InsertClient(Client p)
        {
           
            string cmdStr = "INSERT INTO Clients (id_client,Name, Telephone, Address)VALUES(@id_client,@Name, @Telephone, @Address)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {                
                command.Parameters.AddWithValue("@id_client", p.GetSetId);
                command.Parameters.AddWithValue("@Name", p.GetSetName);
                command.Parameters.AddWithValue("@Telephone", p.GetSetTel);
                command.Parameters.AddWithValue("@Address", p.GetSetAddress);
                base.ExecuteSimpleQuery(command);
            }
        }

        //Insert subject Supliers in db
        public void InsertFirm(Suppliers firm)
        {
            string cmdStr = "INSERT INTO Suppliers (NameCompany, Telephone)VALUES(@Name, @Telephone)";
            ArrayList firms = new ArrayList(GetSuppliersData());
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //if (firm.GetSetIdSupplier == -1)
                //{ command.Parameters.AddWithValue("@id", GetSuppliersNumberMax() + 1); }
                //else
                //{ command.Parameters.AddWithValue("@id", firm.GetSetIdSupplier == -1); }

                command.Parameters.AddWithValue("@Name", firm.GetSetNameCompany);
                command.Parameters.AddWithValue("@Telephone", firm.GetSetTel);
                base.ExecuteSimpleQuery(command);
            }
        }

        //Insert subject Item in db
        public void InsertItem (Item item)
        {
            string cmdStr = "INSERT INTO Items (Item, Price, NameOfCompany)VALUES(@Item, @Price, @NameOfCompany)";
            ArrayList items = new ArrayList(GetSuppliersData());
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                
                command.Parameters.AddWithValue("@Item", item.GetSetItem);
                command.Parameters.AddWithValue("@Price", item.GetSetPrice);
                command.Parameters.AddWithValue("@NameOfCompany", item.GetSetSupplier);
                base.ExecuteSimpleQuery(command);
            }
        }

        //Insert subject Order in db
        public void InsertOrder(Order order)
        {
            string cmdStr = "INSERT INTO Orders (id_client, id_item)VALUES(@client, @Item)";
            ArrayList items = new ArrayList(GetSuppliersData());
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@client", order.GetSetIdClient);
                command.Parameters.AddWithValue("@Item", order.GetSetIdItem);

                base.ExecuteSimpleQuery(command);
            }
        }

        //return quality of Clients in db
        public int GetClientNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Clients";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //return quality of Suppliers in db
        public int GetSuppliersNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Suppliers";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //return quality of Items in db
        public int GetItemsNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Items";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //return quality of Orders in db
        public int GetOrdersNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Orders";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }


        ////return max ID of Items in db
        //public int GetItemsNumberMax()
        //{
        //    int result;
        //    string cmdStr = "SELECT MAX(Id_item) FROM Items";
        //    using (OleDbCommand command = new OleDbCommand(cmdStr))
        //    {
        //        result = ExecuteScalarIntQuery(command);
        //    }
        //    return result;
        //}

        //Get array of Clients
        public Client[] GetClientsData()
        {
            DataSet ds = new DataSet();
            ArrayList clients = new ArrayList();
            string cmdStr = "SELECT * FROM Clients";
            using (OleDbCommand command = new OleDbCommand(cmdStr))            
                ds = GetMultipleQuery(command);
           
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Client client = new Client();
                client.GetSetName = tType[1].ToString();
                client.GetSetTel = tType[2].ToString();
                client.GetSetAddress = tType[3].ToString();
                client.GetSetId = int.Parse(tType[0].ToString());
                clients.Add(client);
            }
            return (Client[])clients.ToArray(typeof(Client));
        }

        //Get array of Suppliers
        public Suppliers[] GetSuppliersData()
        {
            DataSet ds = new DataSet();
            ArrayList firms = new ArrayList();
            string cmdStr = "SELECT * FROM Suppliers";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
                ds = GetMultipleQuery(command);

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Suppliers firm = new Suppliers();
                firm.GetSetNameCompany = tType[0].ToString();
                firm.GetSetTel = tType[1].ToString();
                //firm.GetSetIdSupplier = int.Parse(tType[0].ToString());
                firms.Add(firm);
            }
            return (Suppliers[])firms.ToArray(typeof(Suppliers));
        }

        //Get array of Orders
        public Order[] GetOrdersData()
        {
            DataSet ds = new DataSet();
            ArrayList orders = new ArrayList();
            string cmdStr = "SELECT * FROM Orders";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
                ds = GetMultipleQuery(command);

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Order order = new Order();
                order.GetSetIdOrder = int.Parse(tType[0].ToString());
                order.GetSetIdClient = int.Parse(tType[1].ToString());
                order.GetSetIdItem = int.Parse(tType[2].ToString());
                
                orders.Add(order);
            }
            return (Order[])orders.ToArray(typeof(Order));
        }

        //Get array of Items
        public Item[] GetItemsData()
        {
            DataSet ds = new DataSet();
            ArrayList items = new ArrayList();
            string cmdStr = "SELECT * FROM Items";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
                ds = GetMultipleQuery(command);

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Item item = new Item();
                item.GetSetItem = tType[1].ToString();
                item.GetSetPrice = float.Parse(tType[2].ToString());
                item.GetSetSupplier = tType[3].ToString();
                item.GetSetId = int.Parse(tType[0].ToString());
                items.Add(item);
            }
            return (Item[])items.ToArray(typeof(Item));
        }

        //Delete row in Clients in db
        public void DeleteRowClients(int id)
        {
            string cmdStr = "DELETE FROM Clients WHERE id_client =@id_client ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id_client", id);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Delete row in Orders in db
        public void DeleteRowOrder(int id)
        {
            string cmdStr = "DELETE FROM Orders WHERE Id_order =@id ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", id);
                base.ExecuteSimpleQuery(command);
            }
        }

        //Delete row in Suppliers in db
        public void DeleteRowSuppliers(string name)
        {
            string cmdStr = "DELETE FROM Suppliers WHERE NameCompany =@Name ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@Name", name);
                base.ExecuteSimpleQuery(command);               
            }
            
        }

        //Delete row in Items in db
        public void DeleteRowItems(int id)
        {
            string cmdStr = "DELETE FROM Items WHERE Id_item =@id_item";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id_item", id);
                base.ExecuteSimpleQuery(command);
            }
        }

        public void DeleteRowItems(string name)
        {
            string cmdStr = "DELETE FROM Items WHERE NameOfCompany =@NameOfCompany";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@NameOfCompany", name);
                base.ExecuteSimpleQuery(command);
            }
        }

        // customer table update
        public void UpdateClient(Client p)
        {
            string cmdStr = "UPDATE Clients SET Name = ?, Telephone = ?,  Address = ? WHERE id_client = ?";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("Name", p.GetSetName);
                command.Parameters.AddWithValue("Telephone", p.GetSetTel);
                command.Parameters.AddWithValue("Adress", p.GetSetAddress);
                command.Parameters.AddWithValue("id_client", p.GetSetId);
                base.ExecuteSimpleQuery(command);
            }
        }

        // Supplier table update
        public void UpdateFirm(Suppliers firm)
        {
            string cmdStr = "UPDATE Suppliers SET Telephone = ? WHERE NameCompany = ?";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("Telephone", firm.GetSetTel);
                command.Parameters.AddWithValue("NameCompany", firm.GetSetNameCompany);
                base.ExecuteSimpleQuery(command);
            }
        }


        // Item table update
        public void UpdateItem(Item item)
        {
            string cmdStr = "UPDATE Items SET Item = ?, Price = ?,  NameOfCompany = ? WHERE Id_item = ?";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("Item", item.GetSetItem);
                command.Parameters.AddWithValue("Price", item.GetSetPrice);
                command.Parameters.AddWithValue("NameOfCompany", item.GetSetSupplier);
                command.Parameters.AddWithValue("Id_item", item.GetSetId);
                base.ExecuteSimpleQuery(command);
            }
        }
    }
}
