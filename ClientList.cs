using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oruzh
{
    public class ClientList
    {
        private int id_list;
        private string data;
        private int cost;
        private int id_client;
        private List<Product> products=new List<Product>();

        public ClientList()
        {
            id_list = 0;
            data = "";
            cost = 0;
            id_client = 0;
        }

        public int getIDlist()
        {
            return id_list;
        }
        public void setIDlist(int id_list)
        {
            this.id_list = id_list;
        }

        public string getData()
        {
            return data;
        }
        public void setData(string data)
        {
            this.data = data;
        }

        public int getCost()
        {
            return cost;
        }
        public void setCost(int cost)
        {
            this.cost = cost;
        }

        public int getIDclient()
        {
            return id_client;
        }
        public void setIDclient(int id_client)
        {
            this.id_client = id_client;
        }

        public Product getProduct(int i)
        {
            return products[i];
        }
        public void setProduct(Product product)
        {
            this.products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public int GetListLength()
        {
            return products.Count();
        }
    }
}
