using MySql.Data.MySqlClient;
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
    public partial class ClosedLists : Form
    {
        private DB db = new DB();
        private Panel[] panels = new Panel[200];
        private ClientList clientList = new ClientList();


        public ClosedLists()
        {
            InitializeComponent();

            Navigation navigation = new Navigation(clientList);
            NavigationPanel.Controls.Add(navigation);

        }
        public ClosedLists(ClientList clientList)
        {
            InitializeComponent();
            this.clientList = clientList;
            Navigation navigation = new Navigation(clientList);
            NavigationPanel.Controls.Add(navigation);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClosedLists_Load(object sender, EventArgs e)
        {
            db.OpenConnection();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `list`", db.GetConnection());
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            int j = 0, y=0;
            while (dataReader.Read())
            {

                panels[j] = new Panel();
                Label label = new Label();
                Label price_label = new Label();
                panels[j].BorderStyle = BorderStyle.FixedSingle;
                panels[j].Size = new Size(370, 60);
                panels[j].Location = new Point(0, y);
                panels[j].Cursor = Cursors.Hand;
                label.Size = new Size(300, 20);
                label.Text =Convert.ToString(dataReader.GetDateTime(dataReader.GetOrdinal("data")));
                price_label.Text = dataReader.GetInt32(dataReader.GetOrdinal("cost")) + " руб.";

                price_label.Dock = DockStyle.Bottom;
                panels[j].Controls.Add(label);
                panels[j].Controls.Add(price_label);
                panels[j].Tag = label.Text;
                panels[j].Click += new EventHandler(Product_Click);
                closedlistsPanel.Controls.Add(panels[j]);
                j++;
                y += 65;
            }
            db.CloseConnection();
        }

        private void Product_Click(object sender, EventArgs e)
        {

            int j = 0;
            while (panels[j] != null)
            {
                if (panels[j] == sender)
                {
                    string date = Convert.ToString(((Control)sender).Tag);
                    ClosedListDescription closedListDescription = new ClosedListDescription(date);
                    closedListDescription.Show();
                }
                j++;
            }
        }

    }
}
