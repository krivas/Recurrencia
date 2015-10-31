using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recurrencia.Controller;

namespace Recurrencia
{
    public partial class SearchProduct : Form
    {
        ClientOrder formulario;
        public SearchProduct(ClientOrder orden)
        {
            formulario = orden;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string producto=textBox1.Text;
            DataAcces acceso = new DataAcces();
            if (CodigoRB.Checked == true)
                acceso.searchProductById(producto,dataGridView1);
            else if (ProductoRB.Checked == true)
                acceso.searchProductByName(producto,dataGridView1);
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            DataAcces acceso = new DataAcces();
            acceso.displayProducts(dataGridView1);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            int id;
            string product;
            int price;
            if (e.KeyCode == Keys.Enter)
            {

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    id = (int)row.Cells[0].Value;
                    product = row.Cells[1].Value.ToString();
                    price = (int)row.Cells[2].Value;
                    formulario.SetProduct(id, product, price);
                }


                this.Close();

            }
        }
    }
}
