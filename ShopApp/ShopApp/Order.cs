﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class Order
    {
        private int id_order;
        private int id_client;
        private int id_item;
        private bool delivered;

        public Order()
        {
            this.id_order = -1;
        }

        public int GetSetIdOrder
        {
            get
            {
                return this.id_order;
            }
            set
            {
                if (value > 0)
                    this.id_order = value;
            }
        }
        public int GetSetIdClient
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

        public int GetSetIdItem
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

        public bool GetSetDelivered
        {
            get
            {
                return this.delivered;
            }
            set
            {
                this.delivered = value;
            }
        }



    }
}

