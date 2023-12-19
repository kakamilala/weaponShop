using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oruzh
{
    class Client
    {
        private int id_client;
        private string fio;
        private string phone;

        public Client()
        {
            id_client = 0;
            fio = "";
            phone = "";
        }

        public int getIDClient()
        {
            return id_client;
        }
        public void setIDClent(int id_client)
        {
            this.id_client = id_client;
        }

        public string getFIO()
        {
            return fio;
        }
        public void setFIO(string fio)
        {
            this.fio = fio;
        }

        public string getPhone()
        {
            return phone;
        }
        public void setPhone(string phone)
        {
            this.phone = phone;
        }
    }
}
