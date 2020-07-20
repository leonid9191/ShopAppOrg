using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class Suppliers
    {
        
        private string nameOfCompany;
        private string telephone;

        public Suppliers()
        {
            
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
