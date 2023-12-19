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
    public partial class ProductDescription : Form
    {
        private Product product;
        public ProductDescription(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void costLab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductDescription_Load(object sender, EventArgs e)
        {
            nameLab.Text = product.getName();
            idProductLab.Text = "Код товара: " + product.getIDproduct();
            costLab.Text = "Цена: " + product.getCost() + " руб.";
            quanLab.Text = "Кол-во: " + product.getQuantity();
            descrLab.Text = "Описание:\n" + product.getDescription();
        }

        private void nameLab_Click(object sender, EventArgs e)
        {

        }
    }
}
