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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAcces dataAcces = new DataAcces();
            string user;
            string pass;
            string confirm;
            user = textBox1.Text;
            pass = textBox2.Text;
            confirm = textBox3.Text;
            if (pass.Equals(confirm) == true)
                dataAcces.insertUser(user, pass, confirm);
            else
                MessageBox.Show("Contraseñas imcompatible");
            

        }

       
    }
}
