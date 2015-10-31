﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recurrencia
{
    public partial class ClientOrder : Form
    {
       
        
       

        public ClientOrder()
        {
            InitializeComponent();
        }

    

        private void ClientOrder_Enter(object sender, EventArgs e)
        {
            
        }
        public void SetClient(string id,string name,string lastName)
        {
            CDGTXT.Text = id;
            NOMTXT.Text = name;
            APTXT.Text = lastName;
            
        }

        public void SetProduct(int id,string product,int price)
        {

            int quantity=1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals( id.ToString()))
                {
                     quantity = Convert.ToInt16(row.Cells[2].Value);
                    quantity++;
                    row.Cells[2].Value = quantity;
                    row.Cells[4].Value = quantity * price;
                    RefreshDatagrid();
                    return;
                   
                }
              
            }
            dataGridView1.Rows.Add(id, product, quantity, price,price);
            RefreshDatagrid();
        }

        private void RefreshDatagrid()
        {
            int total=0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += (int)row.Cells[4].Value;
            }
            Total.Text = total.ToString();
        }

      

     

        private void ClientBTN_Click(object sender, EventArgs e)
        {
            SearchClient buscarCliente = new SearchClient(this);
            buscarCliente.Show();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                dataGridView1.Rows.RemoveAt(item.Index);

            }
        }

     

       

        private void FindBTN_Click(object sender, EventArgs e)
        {
            SearchProduct buscarProducto = new SearchProduct(this);
            buscarProducto.Show(); 
        }

     
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 2 )
            {
                this.dataGridView1.ReadOnly = false;
               
                
            }
            else
                this.dataGridView1.ReadOnly = true;
        }

       

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
                int quantity = Convert.ToInt16(row.Cells[2].Value);
                int price = Convert.ToInt16(row.Cells[3].Value);
                int balance = quantity * price;
                row.Cells[4].Value = balance;
                RefreshDatagrid();
             
            }
        }

     

       

     

       
    }
}