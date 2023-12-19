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
    public partial class Catalog : Form
    {
        private DB db = new DB();
        private Panel[] panels = new Panel[200];
        private Product[] products = new Product[200];
        private ClientList clientList=new ClientList();

        public Catalog()
        {
            InitializeComponent();
            Navigation navigation = new Navigation(clientList);
            navigation.Visible = true;
            NavigationPanel.Controls.Add(navigation);
        }

        public Catalog(ClientList clientList)
        {
            InitializeComponent();
            Navigation navigation = new Navigation(clientList);
            navigation.Visible = true;
            NavigationPanel.Controls.Add(navigation);
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `products` WHERE `quantity`>0", db.GetConnection());
            MySqlDataReader dataReader = command.ExecuteReader();

            int i = 0, j = 0, y = 15;
            while (dataReader.Read())
            {
                products[j] = new Product();
                products[j].setIDproduct(dataReader.GetInt32(dataReader.GetOrdinal("idProduct")));
                products[j].setName(dataReader.GetString(dataReader.GetOrdinal("name")));
                products[j].setDescription(dataReader.GetString(dataReader.GetOrdinal("description")));
                products[j].setQuantity(dataReader.GetInt32(dataReader.GetOrdinal("quantity")));
                products[j].setCost(dataReader.GetInt32(dataReader.GetOrdinal("cost")));
                products[j].setLicence(dataReader.GetBoolean(dataReader.GetOrdinal("licence")));


                panels[j] = new Panel();
                Label label = new Label();
                Label price_label = new Label();
                Button add_button = new Button();
                panels[j].BorderStyle = BorderStyle.FixedSingle;
                panels[j].Size = new Size(350, 60);
                panels[j].Location = new Point(0,y);
                panels[j].Cursor = Cursors.Hand;
                label.Size = new Size(200, 20);
                price_label.Size = new Size(200, 20);
                label.Text = dataReader.GetString(dataReader.GetOrdinal("name"));
                price_label.Text = dataReader.GetInt64(dataReader.GetOrdinal("cost")) + " руб.";

                add_button.Text = "Добавить";
                add_button.Dock = DockStyle.Right;
                add_button.Tag = j;
                add_button.Click += new EventHandler(AddButtonClick);

                price_label.Dock = DockStyle.Bottom;
                panels[j].Controls.Add(label);
                panels[j].Controls.Add(price_label);
                panels[j].Controls.Add(add_button);
                panels[j].Click += new EventHandler(Product_Click);
                productsPanel.Controls.Add(panels[j]);
                i++;
                j++;
                y += 65;
            }
            db.CloseConnection();

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(((Control)sender).Tag);
            clientList.setProduct(products[j]);

            MessageBox.Show("Товар " + products[j].getName() + " добавлен в чек!");
        }

        private void Product_Click(object sender, EventArgs e)
        {

            int j = 0;
            while (panels[j] != null)
            {
                if (panels[j] == sender)
                {
                    ProductDescription productDescriptionWindow = new ProductDescription(products[j]);
                    productDescriptionWindow.Show();
                }
                j++;
            }
        }

        private void Сlose_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_but_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            string sql = string.Format("SELECT * FROM `products` WHERE `name` LIKE '%{0}%'", search.Text);
            MySqlCommand mySqlCommand = new MySqlCommand(sql, db.GetConnection());
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();

            productsPanel.Controls.Clear();
            int i = 0, j = 0, y = 15;
            while (dataReader.Read())
            {
                products[j] = new Product();
                products[j].setIDproduct(dataReader.GetInt32(dataReader.GetOrdinal("idProduct")));
                products[j].setName(dataReader.GetString(dataReader.GetOrdinal("name")));
                products[j].setDescription(dataReader.GetString(dataReader.GetOrdinal("description")));
                products[j].setQuantity(dataReader.GetInt32(dataReader.GetOrdinal("quantity")));
                products[j].setCost(dataReader.GetInt32(dataReader.GetOrdinal("cost")));


                panels[j] = new Panel();
                Label label = new Label();
                Label price_label = new Label();
                panels[j].BorderStyle = BorderStyle.FixedSingle;
                panels[j].Size = new Size(370, 60);
                panels[j].Location = new Point(0, y);
                panels[j].Cursor = Cursors.Hand;
                label.Size = new Size(200, 20);
                label.Text = dataReader.GetString(dataReader.GetOrdinal("name"));
                price_label.Text = dataReader.GetInt64(dataReader.GetOrdinal("cost")) + " руб.";

                price_label.Dock = DockStyle.Bottom;
                panels[j].Controls.Add(label);
                panels[j].Controls.Add(price_label);
                panels[j].Click += new EventHandler(Product_Click);
                productsPanel.Controls.Add(panels[j]);
                i++;
                j++;
                y += 65;
            }
            db.CloseConnection();

        }
    }
}
