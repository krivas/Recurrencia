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
     
    public partial class SearchClient : Form
    {

        ClientOrder formulario;
       

        public SearchClient(ClientOrder orden)
        {
            
            formulario = orden;

            InitializeComponent();
           
        }

        public SearchClient()
        {

           

            InitializeComponent();

        }

      

        private void SearchClient_Load(object sender, EventArgs e)
        {
            DataAcces acceso = new DataAcces();
            acceso.displayClients(dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataAcces acceso = new DataAcces();
            string nombre=textBox1.Text;
            if (CodigoRB.Checked == true)
                acceso.searchClientByCode(nombre, dataGridView1);
            else if (ApellidoRB.Checked == true)
                acceso.searchClientByLastName(nombre, dataGridView1);
            else if (NombreRB.Checked == true)
                acceso.searchClientByName(nombre, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
          string id;
            string name;
            string lastName;
            if (e.KeyCode == Keys.Enter)
            {
                                
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                   id= row.Cells[0].Value.ToString();
                   name= row.Cells[1].Value.ToString();
                 lastName= row.Cells[2].Value.ToString();
                 formulario.SetClient(id, name, lastName); 
                }

                
                this.Close();
            
            }
        }

        private void SearchClient_FormClosed(object sender, FormClosedEventArgs e)
        {
                              
        }

        

       

       
    }
}
