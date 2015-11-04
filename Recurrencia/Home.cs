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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            RefreshDatagrid();
            

        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser user = new NewUser();
            user.ShowDialog();
              
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewClient client = new NewClient();
            client.ShowDialog();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProduct product = new NewProduct();
            product.ShowDialog();
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProduct edit = new EditProduct();
            edit.ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClient client = new SearchClient();
            client.ShowDialog();

        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientOrder order = new ClientOrder(this);
            order.ShowDialog();
        }

        public void RefreshDatagrid()
         {
              DataAcces acces = new DataAcces();
            acces.displayPendingOrders(this.dataGridView1);
         }

       

    }
}
