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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAcces dataAcces = new DataAcces();
            Home home = new Home();
        
            string user=textBox1.Text;
            string pass=textBox2.Text;

            if (dataAcces.Login(user, pass) == true)
            {
                home.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Error en el usuario o contraseña");

            

        }

        private void Login_Load(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
