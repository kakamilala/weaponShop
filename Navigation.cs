using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oruzh
{
    public partial class Navigation : UserControl
    {
        private ClientList clientList=new ClientList();

        public Navigation(ClientList clientList)
        {
            InitializeComponent();
            this.Visible = true;
            this.clientList = clientList;
        }

        private void CatalogBut_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog(clientList);
            catalog.Show();
        }

        private void ListBut_Click(object sender, EventArgs e)
        {
            List list = new List(clientList);
            list.Show();
        }

        private void ClosedLists_Click(object sender, EventArgs e)
        {
            ClosedLists closedLists = new ClosedLists(clientList);

            closedLists.Show();
        }
    }
}
