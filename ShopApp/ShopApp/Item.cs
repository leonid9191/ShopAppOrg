using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class Item
    {
        private int id_item;
        private string item;
        private int price;
        private string nameOfCompany;

        public Item()
        {
            this.id_item = -1;
        }

        public int GetSetId
        {
            get
            {
                return this.id_item;
            }
            set
            {
                if (value > 0)
                    this.id_item = value;
            }
        }

        public string GetSetSupplier
        {
            get
            {
                return this.nameOfCompany;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this.nameOfCompany = value;
            }
        }

        public int GetSetPrice
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                    this.price = value;
            }
        }

        public string GetSetItem
        {
            get
            {
                return this.item;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this.item = value;
            }
        }

    }
}
