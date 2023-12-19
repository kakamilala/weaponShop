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
    public partial class List : Form
    {
        private DB db = new DB();
        private ClientList clientList=new ClientList();
        private Panel[] panels = new Panel[200];
        private int licAdI=-1;
        private LicenceAdding[] licenceAddings = new LicenceAdding[200];

        private Licence[] licences = new Licence[200];

        private int cost_ = 0;

        private int idClient;


        public List()
        {
            InitializeComponent();

            Navigation navigation = new Navigation(clientList);
            NavigationPanel.Controls.Add(navigation);

        }
        public List(ClientList clientList)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DoneBut_Click(object sender, EventArgs e)
        {
            if(fioClient.Text!=""&&phoneClient.Text!="")
            {
                Client client = new Client();
                client.setIDClent(idClient);
                client.setFIO(fioClient.Text);
                client.setPhone(phoneClient.Text);

                db.OpenConnection();

                MySqlCommand command = new MySqlCommand("INSERT INTO `clients`(`idClient`, `fio`, `phone`) VALUES (NULL,@fio,@phone)", db.GetConnection());
                command.Parameters.Add("@fio", MySqlDbType.String).Value = client.getFIO();
                command.Parameters.Add("@phone", MySqlDbType.String).Value = client.getPhone();
                command.ExecuteNonQuery();
                db.CloseConnection();

                if(licAdI>-1)
                {
                    for (int i = 0; i <= licAdI; i++)
                    {
                        db.OpenConnection();
                        MySqlCommand command1 = new MySqlCommand("INSERT INTO `licences`(`idLicences`, `type`, `validity_period`, `idClient`, `idProduct`) VALUES (NULL,@type,@period,@idC,@idP)", db.GetConnection());
                        command1.Parameters.Add("@type", MySqlDbType.String).Value = licenceAddings[i].GetLicence().getType();
                        command1.Parameters.Add("@period", MySqlDbType.Date).Value = licenceAddings[i].GetLicence().getValid();
                        command1.Parameters.Add("@idC", MySqlDbType.Int32).Value = client.getIDClient();
                        command1.Parameters.Add("@idP", MySqlDbType.Int32).Value = licenceAddings[i].GetLicence().getIDproduct();

                        command1.ExecuteNonQuery();
                        db.CloseConnection();
                    }
                }
                

                DateTime dateTime = DateTime.Now;
                db.OpenConnection();
                MySqlCommand command2 = new MySqlCommand("INSERT INTO `list`(`idList`, `data`, `cost`, `idClient`) VALUES (NULL,@data,@cost,@idC)", db.GetConnection());
                command2.Parameters.Add("@data", MySqlDbType.DateTime).Value = dateTime;
                command2.Parameters.Add("@idC", MySqlDbType.Int32).Value = client.getIDClient();
                command2.Parameters.Add("@cost", MySqlDbType.Int32).Value = cost_;

                command2.ExecuteNonQuery();

                db.CloseConnection();

                db.OpenConnection();

                MySqlCommand command_ = new MySqlCommand("SELECT MAX(`idList`)  FROM `list`", db.GetConnection());
                int idList = Convert.ToInt32(command_.ExecuteScalar());

                for (int i=0; i<clientList.GetListLength();i++)
                {
                    MySqlCommand command3 = new MySqlCommand("INSERT INTO `list_structure`(`idList_structure`, `idList`, `idProduct`) VALUES (NULL,@idL,@idP)", db.GetConnection());
                    command3.Parameters.Add("@idL", MySqlDbType.Int32).Value = idList;
                    command3.Parameters.Add("@idP", MySqlDbType.Int32).Value = clientList.getProduct(i).getIDproduct();

                    command3.ExecuteNonQuery();
                }
                db.CloseConnection();

                MessageBox.Show("Чек закрыт!");
                this.Close();
            }
        }

        private void List_Load(object sender, EventArgs e)
        {

            db.OpenConnection();
            MySqlCommand command_ = new MySqlCommand("SELECT MAX(`idClient`) FROM `clients`", db.GetConnection());
            idClient = Convert.ToInt32(command_.ExecuteScalar());
            db.CloseConnection();

            int y=0;
            int j = 0;
            if (clientList.GetListLength()>0)
            {
                while (j<clientList.GetListLength())
                {
                    db.OpenConnection();
                    

                    panels[j] = new Panel();

                    MySqlCommand command = new MySqlCommand("SELECT `licence` FROM `products` WHERE `name`=@name", db.GetConnection());
                    command.Parameters.Add("@name", MySqlDbType.String).Value = clientList.getProduct(j).getName();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    dataReader.Read();

                    if(dataReader.GetBoolean(dataReader.GetOrdinal("licence")))
                    {
                        Button button = new Button();
                        button.Text = "Лицензия";
                        button.Dock = DockStyle.Right;

                        button.Tag = clientList.getProduct(j).getIDproduct(); ;
                        button.Click +=new EventHandler(button_Click);
                        panels[j].Controls.Add(button);
                    }
                    db.CloseConnection();
                    Label label = new Label();
                    Label price_label = new Label();
                    
                    panels[j].BorderStyle = BorderStyle.FixedSingle;
                    panels[j].Size = new Size(350, 60);
                    panels[j].Location = new Point(0, y);
                    label.Size = new Size(200, 20);
                    price_label.Size = new Size(200, 20);
                    label.Text = clientList.getProduct(j).getName();
                    price_label.Text = Convert.ToString(clientList.getProduct(j).getCost());

                    price_label.Dock = DockStyle.Bottom;
                    panels[j].Controls.Add(label);
                    panels[j].Controls.Add(price_label);
                    ProductPanelList.Controls.Add(panels[j]);

                    cost_ += clientList.getProduct(j).getCost();

                    j++;
                    y += 65;

                }

                
            }

            cost.Text = cost_ + "руб.";
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            int idProduct = Convert.ToInt32(((Control)sender).Tag);
            licAdI += 1;
            licenceAddings[licAdI] = new LicenceAdding();
            licenceAddings[licAdI].setID(idClient, idProduct);
            licenceAddings[licAdI].Show();

        }

        private void cost_Click(object sender, EventArgs e)
        {

        }
    }
}
