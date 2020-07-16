using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class Suppliers
    {
        private int id_supplier;
        private string nameOfCompany;
        private string telephone;

        public Suppliers()
        {
            this.id_supplier = -1;
        }

        public int GetSetIdSupplier
        {
            get
            {
                return this.id_supplier;
            }
            set
            {
                if (value > 0)
                    this.id_supplier = value;
            }
        }

        

        public string GetSetNameCompany
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

    }
}
