using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Recurrencia.Model;

namespace Recurrencia.Controller

{
    class DataAcces
    {
        private string conecctionString;
        private SqlConnection conecction;
        private SqlCommand command;
        private SqlParameter parameter;

        public DataAcces()
        {
            this.conecctionString = "Server= KEVIN-PC\\SQLEXPRESS; Database= Recurrencia; Integrated Security=SSPI;";
            this.conecction = new SqlConnection(this.conecctionString );

            try
            {
                this.conecction.Open();
                this.conecction.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No hay conexion con la base de datos ! " + ex);
            }

            finally
            {
                this.conecction.Close();
            }

        }


        public bool  Login(string user,string password)
        {

            command = new SqlCommand("select count(*) from Usuarios where usuario=@user and contraseña=@pass", conecction);
            parameter = new SqlParameter();
            parameter.ParameterName = "@user";
            parameter.Value = user;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@pass";
            parameter.Value = password;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.Add(parameter);
            try
            {
                conecction.Open();
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                conecction.Close();
                if (count == 1)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error ! " + ex);
                return false;
            }
            finally
            {
                
                conecction.Close();

            }
        }

        public void insertUser(string user, string password,string confirm)
        {
            command = new SqlCommand("Insert into Usuarios (usuario,contraseña) Values (@user,@pass)", conecction);
            parameter = new SqlParameter();
            parameter.ParameterName = "@user";
            parameter.Value = user;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@pass";
            parameter.Value = password;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.Add(parameter);

            try
            {
                conecction.Open();
                command.ExecuteNonQuery();
                conecction.Close();
                MessageBox.Show("Producto nuevo agregado");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error ! " + ex);
            }
            finally
            {
                conecction.Close();
            }



        }

        public void insertClient(Client client)
        {
           

                command = new SqlCommand("Insert into Clientes (Nombre,Apellido,Numero_Socio,Empresa,Tipo_Cliente,Correo,Correo_Alterno,Telefono_Hogar,Telefono_Celular,Telefono_Trabajo,Extension) Values (@nombre,@apellido,@numeroSocio,@empresa,@tipoCliente,@correo,@correoAlterno,@telefonoHogar,@telefonoCelular,@telefonoTrabajo,@extension)", conecction);

                parameter = new SqlParameter();
                parameter.ParameterName = "@nombre";
                parameter.Value = client.Name;
                parameter.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(parameter);

               parameter = new SqlParameter();
               parameter.ParameterName = "@apellido";
               parameter.Value = client.LastName;
               parameter.SqlDbType = SqlDbType.VarChar;
               command.Parameters.Add(parameter);

                parameter = new SqlParameter();
               parameter.ParameterName = "@numeroSocio";
               parameter.Value = client.SocialNumber;
               parameter.SqlDbType = SqlDbType.NChar;
               command.Parameters.Add(parameter);


               parameter = new SqlParameter();
               parameter.ParameterName = "@empresa";
               parameter.Value = client.Business;
               parameter.SqlDbType = SqlDbType.NText;
               command.Parameters.Add(parameter);
               
               parameter = new SqlParameter();
               parameter.ParameterName = "@tipoCliente";
               parameter.Value = client.ClientType;
               parameter.SqlDbType = SqlDbType.VarChar;
               command.Parameters.Add(parameter);

               parameter = new SqlParameter();
               parameter.ParameterName = "@correo";
               parameter.Value = client.Email;
               parameter.SqlDbType = SqlDbType.VarChar;
               command.Parameters.Add(parameter);
               
               parameter = new SqlParameter();
               parameter.ParameterName = "@correoAlterno";
               parameter.Value = client.AlternateEmail;
               parameter.SqlDbType = SqlDbType.VarChar;
               command.Parameters.Add(parameter);

               parameter = new SqlParameter();
               parameter.ParameterName = "@telefonoHogar";
               parameter.Value = client.HomePhone;
               parameter.SqlDbType = SqlDbType.VarChar;
               command.Parameters.Add(parameter);
                
               parameter = new SqlParameter();
               parameter.ParameterName = "@telefonoCelular";
               parameter.Value = client.CellPhone;
               parameter.SqlDbType = SqlDbType.VarChar;
               command.Parameters.Add(parameter);
              
               parameter = new SqlParameter();
               parameter.ParameterName = "@telefonoTrabajo";
               parameter.Value = client.WorkPhone;
               parameter.SqlDbType = SqlDbType.VarChar;
               command.Parameters.Add(parameter);
               
               parameter = new SqlParameter();
               parameter.ParameterName = "@extension";
               parameter.Value = client.Extention;
               parameter.SqlDbType = SqlDbType.VarChar;
               command.Parameters.Add(parameter);
                
                
          
              
                try
                {
                    conecction.Open();
                    command.ExecuteNonQuery();
                    conecction.Close();
                    MessageBox.Show("Cliente nuevo agregado");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error ! " + ex);
                }
                finally
                {
                    conecction.Close();
                }
        }

        public void insertProduct(Product product)
        {

            command = new SqlCommand("Insert into Productos (Producto,Precio_Unidad,Comentario) Values (@producto,@precio,@comentario)", conecction);

            parameter = new SqlParameter();
            parameter.ParameterName = "@producto";
            parameter.Value = product.Description;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@precio";
            parameter.Value = product.Price;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(parameter);


            parameter = new SqlParameter();
            parameter.ParameterName = "@comentario";
            parameter.Value = product.Comment;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.Add(parameter);

            try
            {
                conecction.Open();
                command.ExecuteNonQuery();
                conecction.Close();
                MessageBox.Show("Producto nuevo agregada");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error ! " + ex);
            }
            finally
            {
                conecction.Close();
            }
        }

        public void displayProducts(DataGridView datagrid)
        {
            string products = "select * from Productos";
            SqlDataAdapter dataadapter = new SqlDataAdapter(products,conecction );
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Productos");
            datagrid.DataSource = ds.Tables[0];
            
        }

        public void displayClients(DataGridView datagrid)
        {
            string clientes = "select * from Clientes";
            SqlDataAdapter dataadapter = new SqlDataAdapter(clientes, conecction);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Clientes");
            datagrid.DataSource = ds.Tables[0];

        }

        public void displayPendingOrders(DataGridView datagrid)
        {
            string ordenes = "select C.Nombre,O.Fecha_Entrega,T.Producto,"+
                            "C.Telefono_Celular,C.Telefono_Hogar,C.Telefono_Trabajo from Ordenes O "+
                             "join Clientes C on (O.ID_Cliente=C.ID_Cliente)" +
                            "join Pedidos P  on (P.ID_Orden=O.ID_Orden)" +
                            "join Productos T on (T.ID_Producto=P.ID_Producto)" +
                            "where Fecha_Entrega >=getdate()"+
                             "order by Fecha_Entrega;";
            SqlDataAdapter dataadapter = new SqlDataAdapter(ordenes, conecction);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Clientes");
            datagrid.DataSource = ds.Tables[0];
        }

        public void searchProductById(string id,DataGridView datagrid)
        {

            command = new SqlCommand("Select *  from Productos where ID_Producto like @id", conecction);

            parameter = new SqlParameter();
            parameter.ParameterName = "@id";
            parameter.Value = id;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.AddWithValue("@id", id + "%");

            command.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "id");

            datagrid.DataSource = ds.Tables[0];

            


        }

        public void searchProductByName(string name, DataGridView datagrid)
        {

            command = new SqlCommand("Select *  from Productos where Producto like @name", conecction);

            parameter = new SqlParameter();
            parameter.ParameterName = "@name";
            parameter.Value = name;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.AddWithValue("@name", name + "%");

            command.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "name");

            datagrid.DataSource = ds.Tables[0];

        }

        public void searchClientByName(string name, DataGridView datagrid)
        {

            command = new SqlCommand("Select *  from Clientes where Nombre like @name", conecction);

            parameter = new SqlParameter();
            parameter.ParameterName = "@name";
            parameter.Value = name;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.AddWithValue("@name", name + "%");

            command.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "name");

            datagrid.DataSource = ds.Tables[0];

        }

        public void searchClientByCode(string name, DataGridView datagrid)
        {

            command = new SqlCommand("Select *  from Clientes where ID_Cliente like @name", conecction);

            parameter = new SqlParameter();
            parameter.ParameterName = "@name";
            parameter.Value = name;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.AddWithValue("@name", name + "%");

            command.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "name");

            datagrid.DataSource = ds.Tables[0];

        }


        public void searchClientByLastName(string name, DataGridView datagrid)
        {

            command = new SqlCommand("Select *  from Clientes where Apellido like @name", conecction);

            parameter = new SqlParameter();
            parameter.ParameterName = "@name";
            parameter.Value = name;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.AddWithValue("@name", name + "%");

            command.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "name");

            datagrid.DataSource = ds.Tables[0];

        }

        public void saveOrder(Order order)
        {
            command = new SqlCommand("Insert into Ordenes (ID_Cliente,Fecha_Orden,Fecha_Entrega,Total) Values (@id,@OrderDate,@RequireDate,@total)", conecction);

            parameter = new SqlParameter();
            parameter.ParameterName = "@id";
            parameter.Value =order.IdClient;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@OrderDate";
            parameter.Value = order.OriginDate;
            parameter.SqlDbType = SqlDbType.DateTime;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@RequireDate";
            parameter.Value = order.ReleaseDate;
            parameter.SqlDbType = SqlDbType.DateTime;
            command.Parameters.Add(parameter);
            parameter = new SqlParameter();

            parameter.ParameterName = "@total";
            parameter.Value = order.Total;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(parameter);


            try
            {
                conecction.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Orden agregada");
                conecction.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            finally
            {
                conecction.Close();
            }
    
        }

        public void saveOrderProducts(Product product)
        {
            command = new SqlCommand("Insert into Pedidos (ID_Orden,ID_Producto,Cantidad,Precio) Values (@idOrder,@idProduct,@quantity,@price)", conecction);
            int id =lastOrderId();

            parameter = new SqlParameter();
            parameter.ParameterName = "@idOrder";
            parameter.Value = id;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(parameter);


            parameter = new SqlParameter();
            parameter.ParameterName = "@idProduct";
            parameter.Value = product.Id;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@quantity";
            parameter.Value =product.Quantity;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@price";
            parameter.Value = product.Price;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(parameter);

            try
            {
                conecction.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("pedido agregado");
                conecction.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            finally
            {
                conecction.Close();
            }

        }

        private int lastOrderId()
        {
            SqlCommand tempCommand = new SqlCommand("Select top 1 ID_Orden from Ordenes order by ID_Orden desc;", conecction);
            try
            {
                conecction.Open();
               int orderId = (int) tempCommand.ExecuteScalar();
                conecction.Close();
                return orderId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            finally
            {
                conecction.Close();
            }

            return 0;
        }

        public void UpdateProduct(Product product)
        {

            command = new SqlCommand("UPDATE Productos SET Producto=@product, Cantidad=@quantity,Precio_Unidad=@price ,Comentario=@comment WHERE ID_Producto=@id", conecction);

            parameter = new SqlParameter();
            parameter.ParameterName = "@id";
            parameter.Value = product.Id;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@product";
            parameter.Value = product.Description;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@quantity";
            parameter.Value = product.Quantity;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@price";
            parameter.Value = product.Price;
            parameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@comment";
            parameter.Value = product.Comment;
            parameter.SqlDbType = SqlDbType.VarChar;
            command.Parameters.Add(parameter);

            try
            {
                conecction.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Producto Editado");
                conecction.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            finally
            {
                conecction.Close();
            }
        
        }

       
    }
}
