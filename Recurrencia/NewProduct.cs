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
using Recurrencia.Model;

namespace Recurrencia
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAcces dataAcces = new DataAcces();
            
            try
            {
                string description = productoTxt.Text;
                int quantity = int.Parse(cantidadTxt.Text);
                int price = int.Parse(precioTxt.Text);
                string comment = comentarioTxt.Text;
                Product product = new Product(description, price, comment);
                dataAcces.insertProduct(product);
                productoTxt.Clear();
                cantidadTxt.Clear();
                precioTxt.Clear();
                comentarioTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos incorrectos! Favor revisar");
            }
           


            
        }

       
    }
}
