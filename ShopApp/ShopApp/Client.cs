using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pikiner Artem
//Chernobylskiy Leonid

namespace ShopApp
{
    public class Client
    {
        private int id_client;
        private string name;
        private string telephone;
        private string address;

        public Client()
        {
            this.id_client = -1;
        }

        //Getters and  setters for parametrs
        public int GetSetId
        {
            get
            {
                return this.id_client;
            }
            set
            {
                if (value > 0)
                    this.id_client = value;
            }
        }

        public string GetSetTel
        {
            get
            {
                return this.telephone;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this.telephone = value;
            }
        }

        public string GetSetAddress
        {
            get
            {
                return this.address;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this.address = value;
            }
        }

        public string GetSetName
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this.name = value;
            }
        }
    }
}
