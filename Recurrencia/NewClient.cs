using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recurrencia.Model;
using Recurrencia.Controller;



namespace Recurrencia
{
    public partial class NewClient : Form
    {
        Button btnMedicina = new Button();
        NewClient formulario;

        public NewClient()
        {
            
            InitializeComponent();
        }

      
        private void NewClient_Load(object sender, EventArgs e)
        {
            
        }

    

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre=nombreTxt.Text;
            string apellido = apellidoTxt.Text;
            string tipoCliente=tipoClienteCmb.Text;
            string numeroSocio=numeroSocioTxt.Text;
            string empresa=EmpresaTxt.Text;
            string direccion=DireccionTxt.Text;
            string direccionAlterna=direccionAlternaTxt.Text;
            string telefonoHogar=telefonoHogarTxt.Text;
            string celular=CelularTxt.Text;
            string trabajo=trabajoTxt.Text;
            string extension=extensionTxt.Text;
            string correo=correoTxt.Text;
            string correoAlterno = correoAlternoTxt.Text;
 
            Client cliente=new Client(nombre,apellido,numeroSocio,celular,telefonoHogar,trabajo,direccion,direccionAlterna,correo,correoAlterno,tipoCliente,extension,empresa);
            DataAcces baseDatos = new DataAcces();
            baseDatos.insertClient(cliente);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

       
    }
}
