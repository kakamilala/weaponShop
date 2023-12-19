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
    public partial class LicenceAdding : Form
    {
        Licence licence = new Licence();

        private int idClient, idProduct;

        public LicenceAdding()
        {
            InitializeComponent();
        }

        public void setID(int idClient, int idProduct)
        {
            this.idClient = idClient;
            this.idProduct = idProduct;
        }

        public Licence GetLicence()
        {
            return licence;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            licence.setIDlicence(Convert.ToInt32(idLicence.Text));
            licence.setType(typelic.Text);
            licence.setValid(Convert.ToString(period.Text));
            licence.setIDclient(idClient);
            licence.setIDproduct(idProduct);

            this.Close();
            
        }
    }
}
