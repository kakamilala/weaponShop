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
    public partial class ClosedListDescription : Form
    {
        DB db = new DB();
        string date="";
        public ClosedListDescription(string date)
        {
            InitializeComponent();
            this.date = date;
        }

        private void ClosedListDescription_Load(object sender, EventArgs e)
        {
            db.OpenConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `list`,`clients` WHERE `data`=@date", db.GetConnection());
            mySqlCommand.Parameters.Add("@date", MySqlDbType.DateTime).Value = Convert.ToDateTime(date);
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            dataReader.Read();

            int idlist = dataReader.GetInt32(dataReader.GetOrdinal("idList"));
            dateLab.Text = Convert.ToString(dataReader.GetDateTime(dataReader.GetOrdinal("data")));
            costLab.Text = "Сумма: " + dataReader.GetInt32(dataReader.GetOrdinal("cost"))+" руб.";
            clientLab.Text = "Покупатель: " + dataReader.GetString(dataReader.GetOrdinal("fio"));
            db.CloseConnection();

            db.OpenConnection();
            MySqlCommand mySqlCommand_ = new MySqlCommand("SELECT * FROM `list_structure`,`products` WHERE `idList`=@idL and `list_structure`.`idProduct`=`products`.`idProduct`", db.GetConnection());
            mySqlCommand_.Parameters.Add("@idL", MySqlDbType.Int32).Value = idlist;
            MySqlDataReader dataReader_ = mySqlCommand_.ExecuteReader();
            productsLab.Text = "Товары:\n";
            while (dataReader_.Read())
            {
                productsLab.Text+= "-"+dataReader_.GetString(dataReader_.GetOrdinal("name"))+", ";
                productsLab.Text += dataReader_.GetInt32(dataReader_.GetOrdinal("cost")) + " руб.\n";
            }
            db.CloseConnection();

        }

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
