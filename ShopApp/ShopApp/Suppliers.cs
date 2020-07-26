using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pikiner Artem
//Chernobylskiy Leonid
namespace ShopApp
{
    public class Suppliers
    {
        
        private string nameOfCompany;
        private string telephone;

        public Suppliers()
        {
            
        }

        //Getters and  setters for parametrs
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
