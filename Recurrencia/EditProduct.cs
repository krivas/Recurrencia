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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            DataAcces dataAcces=new DataAcces();
            dataAcces.displayProducts(dataGridView1);
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataAcces dataAcces = new DataAcces();
            string buscar = buscarTxt.Text;
            if (radioButton1.Checked == true)
                dataAcces.searchProductById(buscar, dataGridView1);
            else
                dataAcces.searchProductByName(buscar, dataGridView1);
            

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                productoTxt.Text = row.Cells[1].Value.ToString();
               
                precioTxt.Text = row.Cells[2].Value.ToString();
              
               
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           
            try
            {
                DataAcces dataAcces = new DataAcces();
                string tempID;
                string description = productoTxt.Text;
                int price = int.Parse(precioTxt.Text);


             
                Product product = new Product(description, price);

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    tempID = row.Cells[0].Value.ToString();
                    product.Id = int.Parse(tempID);
                }
                dataAcces.UpdateProduct(product);
                dataAcces.displayProducts(dataGridView1);
                productoTxt.Clear();
                precioTxt.Clear();
               
             
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error "+ ex);  
            }
            
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

       

       

       
    }
}
