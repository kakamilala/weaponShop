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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Enter_but_Click(object sender, EventArgs e)
        {
           if(login.Text=="admin"&&pass.Text=="admin")
           {
                Catalog catalog = new Catalog();
                catalog.Show();
                this.Visible = false;  
           }
           else
           {
                MessageBox.Show("Неправильный логин или пароль!");
           }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void close_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
