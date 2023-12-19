using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oruzh
{
    public class Licence
    {
        private int id_licence;
        private string type;
        private string validity_period;
        private int id_client;
        private int id_product;

        public Licence()
        {
            id_licence = 0;
            type = "";
            validity_period = "";
            id_client = 0;
            id_product = 0;
        }

        public int getIDlicence()
        {
            return id_licence;
        }
        public void setIDlicence(int id_licence)
        {
            this.id_licence = id_licence;
        }

        public string getType()
        {
            return type;
        }
        public void setType(string type)
        {
            this.type = type;
        }

        public string getValid()
        {
            return validity_period;
        }
        public void setValid(string valid)
        {
            this.validity_period = valid;
        }

        public int getIDclient()
        {
            return id_client;
        }
        public void setIDclient(int id_client)
        {
            this.id_client = id_client;
        }

        public int getIDproduct()
        {
            return id_product;
        }
        public void setIDproduct(int id_product)
        {
            this.id_product = id_product;
        }

    }
}
