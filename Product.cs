using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oruzh
{
    public class Product
    {
        private int id_product;
        private string name;
        private string description;
        private int quantity;
        private int cost;
        private bool licence;

        public Product()
        {
            id_product = 0;
            name = "";
            quantity = 0; 
            description = "";
            cost = 0;
            licence = false;
        }

        public int getIDproduct()
        {
            return id_product;
        }
        public void setIDproduct(int id_product)
        {
            this.id_product = id_product;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return description;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }

        public int getQuantity()
        {
            return quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int getCost()
        {
            return cost;
        }
        public void setCost(int price)
        {
            this.cost = price;
        }

        public bool getLicence()
        {
            return licence;
        }
        public void setLicence(bool licence)
        {
            this.licence = licence;
        }
    }
}
