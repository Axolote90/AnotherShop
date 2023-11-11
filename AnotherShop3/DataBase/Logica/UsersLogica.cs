using System;
using System.Collections.Generic;
using System.Configuration;
using AnotherShop3.DataBase.Modelo;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace AnotherShop3.DataBase.Logica
{
    internal class UsersLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static UsersLogica _instancia = null;

        public UsersLogica() { }

        public static UsersLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UsersLogica();
                }
                return _instancia;
            }
        }

        public bool Guardar(Users obj)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "INSERT INTO Acount (UserName, Password, Mail, Phone, Tienda) VALUES (@UserName, @Password, @Mail, @Phone, @Tienda)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.Add(new SQLiteParameter("@UserName", obj.UserName));
                    cmd.Parameters.Add(new SQLiteParameter("@Password", obj.Password));
                    cmd.Parameters.Add(new SQLiteParameter("@Mail", obj.Mail));
                    cmd.Parameters.Add(new SQLiteParameter("@Phone", obj.Phone));
                    cmd.Parameters.Add(new SQLiteParameter("@Tienda",obj.Tienda));
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                respuesta = false;
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                respuesta = false;
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }

            return respuesta;
        }

        public List<Users> Listar()
        {
            List<Users> oLista = new List<Users>();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Acount";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Users()
                            {
                                ID = int.Parse(dr["ID"].ToString()),
                                UserName = (dr["UserName"].ToString()),
                                Password = (dr["Password"].ToString()),
                                Mail = (dr["Mail"].ToString()),
                                Phone = (dr["Phone"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                MessageBox.Show("Error al listar desde la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                MessageBox.Show("Se produjo un error al intentar listar: " + ex.Message);
            }

            return oLista;
        }


        public string BuscarContraseñaPorNombreUsuario(string nombreUsuario)
        {
            string contraseña = null;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT Password FROM Acount WHERE UserName = @UserName";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@UserName", nombreUsuario));
                    cmd.CommandType = System.Data.CommandType.Text;

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        contraseña = result.ToString();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                MessageBox.Show("Error al buscar la contraseña desde la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                MessageBox.Show("Se produjo un error al intentar buscar la contraseña: " + ex.Message);
            }

            return contraseña;
        }


        public Users ObtenerPorID(int id)
        {
            Users usuario = null;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Acount WHERE ID = @ID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@ID", id));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuario = new Users()
                            {
                                ID = int.Parse(dr["ID"].ToString()),
                                UserName = (dr["UserName"].ToString()),
                                Password = (dr["Password"].ToString()),
                                Mail = (dr["Mail"].ToString()),
                                Phone = (dr["Phone"].ToString()),
                            };
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                MessageBox.Show("Error al obtener el usuario por ID desde la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                MessageBox.Show("Se produjo un error al intentar obtener el usuario por ID: " + ex.Message);
            }

            return usuario;
        }


        public bool EliminarPorID(int id)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "DELETE FROM Acount WHERE ID = @ID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@ID", id));
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false; // No se eliminó ninguna fila, es decir, el ID no se encontró.
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                respuesta = false;
                MessageBox.Show("Error al intentar eliminar el usuario por ID desde la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                respuesta = false;
                MessageBox.Show("Se produjo un error al intentar eliminar el usuario por ID: " + ex.Message);
            }

            return respuesta;
        }


        public int ObtenerIDPorNombreUsuario(string nombreUsuario)
        {
            int id = -1; // Valor por defecto si no se encuentra el nombre de usuario

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT ID FROM Acount WHERE UserName = @UserName";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@UserName", nombreUsuario));
                    cmd.CommandType = System.Data.CommandType.Text;

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        id = Convert.ToInt32(result); // Convierte el resultado a un entero si se encuentra el nombre de usuario
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                MessageBox.Show("Error al obtener el ID por nombre de usuario desde la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                MessageBox.Show("Se produjo un error al intentar obtener el ID por nombre de usuario: " + ex.Message);
            }

            return id;
        }


        public bool EditarPorID(int id, Users nuevoUsuario)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "UPDATE Acount SET UserName = @UserName, Mail = @Mail, Phone = @Phone WHERE ID = @ID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.Add(new SQLiteParameter("@UserName", nuevoUsuario.UserName));
                    cmd.Parameters.Add(new SQLiteParameter("@Mail", nuevoUsuario.Mail));
                    cmd.Parameters.Add(new SQLiteParameter("@Phone", nuevoUsuario.Phone));
                    cmd.Parameters.Add(new SQLiteParameter("@ID", id));
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false; // No se editó ninguna fila, es decir, el ID no se encontró.
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                respuesta = false;
                MessageBox.Show("Error al intentar editar el usuario por ID en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                respuesta = false;
                MessageBox.Show("Se produjo un error al intentar editar el usuario por ID: " + ex.Message);
            }

            return respuesta;
        }


        public bool EditarContraseñaPorID(int id, Users nuevoUsuario)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "UPDATE Acount SET Password = @Password WHERE ID = @ID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.Add(new SQLiteParameter("@Password", nuevoUsuario.Password));
                    cmd.Parameters.Add(new SQLiteParameter("@ID", id));
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false; // No se editó ninguna fila, es decir, el ID no se encontró.
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                respuesta = false;
                MessageBox.Show("Error al intentar editar la contraseña por ID en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                respuesta = false;
                MessageBox.Show("Se produjo un error al intentar editar la contraseña por ID: " + ex.Message);
            }

            return respuesta;
        }

        public void GuardarImagen(int id, Image imagen)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Convertir la imagen a bytes
                    imagen.Save(ms, imagen.RawFormat);
                    byte[] datosImagen = ms.ToArray();

                    using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                    {
                        conexion.Open();

                        // Verificar si ya existe una imagen para el ID, si sí, actualizarla; si no, insertarla.
                        string verificarExistenciaQuery = "SELECT COUNT(*) FROM Acount WHERE ID = @ID";
                        SQLiteCommand verificarExistenciaCmd = new SQLiteCommand(verificarExistenciaQuery, conexion);
                        verificarExistenciaCmd.Parameters.AddWithValue("@ID", id);

                        int existe = Convert.ToInt32(verificarExistenciaCmd.ExecuteScalar());

                        string query;
                        SQLiteCommand cmd;

                        if (existe > 0)
                        {
                            query = "UPDATE Acount SET Image = @Image WHERE ID = @ID";
                            cmd = new SQLiteCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@ID", id);
                        }
                        else
                        {
                            query = "INSERT INTO Acount (ID, Image) VALUES (@ID, @Image)";
                            cmd = new SQLiteCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@ID", id);
                        }

                        cmd.Parameters.AddWithValue("@Image", datosImagen);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, registrándola en un logger
                Console.WriteLine("Error al guardar la imagen en la base de datos: " + ex.Message);
            }
        }

        public Image ObtenerImagenPorID(int id)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT Image FROM Acount WHERE ID = @ID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            byte[] datosImagen = (byte[])dr["Image"];

                            // Convertir los bytes de la imagen a un objeto Image
                            using (MemoryStream ms = new MemoryStream(datosImagen))
                            {
                                return Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, registrándola en un logger
                Console.WriteLine("Error al obtener la imagen desde la base de datos: " + ex.Message);
            }

            return null;
        }

        public void EliminarTodosLosDatos()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    // Eliminar todos los datos de la tabla Acount
                    string query = "DELETE FROM Acount";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                MessageBox.Show("Error al intentar eliminar todos los datos desde la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                MessageBox.Show("Se produjo un error al intentar eliminar todos los datos: " + ex.Message);
            }
        }

        public void CrearNuevaTabla()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    // Encontrar el número de la última tabla creada
                    int ultimoNumeroTabla = ObtenerUltimoNumeroTabla(conexion);

                    // Crear el nombre de la nueva tabla
                    string nombreTabla = "Shop" + (ultimoNumeroTabla + 1);

                    // Crear la tabla "Shop" con las columnas ID, Producto, Precio y Descripción
                    string query = $"CREATE TABLE {nombreTabla} (ID INTEGER PRIMARY KEY AUTOINCREMENT, Producto TEXT, Precio REAL, Descripcion TEXT)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Se ha creado una nueva tabla llamada {nombreTabla}.");
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                MessageBox.Show("Error al intentar crear una nueva tabla: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                MessageBox.Show("Se produjo un error al intentar crear una nueva tabla: " + ex.Message);
            }
        }

        private int ObtenerUltimoNumeroTabla(SQLiteConnection conexion)
        {
            int ultimoNumero = 0;

            try
            {
                // Buscar el número de la última tabla creada
                string query = "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name LIKE 'Shop%'";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    ultimoNumero = Convert.ToInt32(result);
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                MessageBox.Show("Error al intentar obtener el último número de tabla: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                MessageBox.Show("Se produjo un error al intentar obtener el último número de tabla: " + ex.Message);
            }

            return ultimoNumero;
        }

        public void InsertarProductoYPrecioEnShop(string producto, double precio)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    // Encontrar el número de la última tabla creada
                    int ultimoNumeroTabla = ObtenerUltimoNumeroTabla(conexion);

                    // Crear el nombre de la tabla "Shop" con el número correspondiente
                    string nombreTabla = "Shop" + ultimoNumeroTabla;

                    // Insertar datos en las columnas "Producto" y "Precio" de la tabla "Shop"
                    string query = $"INSERT INTO {nombreTabla} (Producto, Precio) VALUES (@Producto, @Precio)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Producto", producto);
                    cmd.Parameters.AddWithValue("@Precio", precio);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Datos de producto y precio insertados en la tabla {nombreTabla}.");
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                MessageBox.Show("Error al intentar insertar datos de producto y precio en la tabla Shop: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                MessageBox.Show("Se produjo un error al intentar insertar datos de producto y precio en la tabla Shop: " + ex.Message);
            }
        }

        public void InsertarDescripcionEnShop(string descripcion)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    // Encontrar el número de la última tabla creada
                    int ultimoNumeroTabla = ObtenerUltimoNumeroTabla(conexion);

                    // Crear el nombre de la tabla "Shop" con el número correspondiente
                    string nombreTabla = "Shop" + ultimoNumeroTabla;

                    // Insertar datos en la columna "Descripcion" de la tabla "Shop"
                    string query = $"INSERT INTO {nombreTabla} (Descripcion) VALUES (@Descripcion)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Datos de descripción insertados en la tabla {nombreTabla}.");
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                MessageBox.Show("Error al intentar insertar datos de descripción en la tabla Shop: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                MessageBox.Show("Se produjo un error al intentar insertar datos de descripción en la tabla Shop: " + ex.Message);
            }
        }

        public bool ExisteNombreUsuario(string nombreUsuario)
        {
            bool existe = false;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT COUNT(*) FROM Acount WHERE UserName = @UserName";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@UserName", nombreUsuario));
                    cmd.CommandType = System.Data.CommandType.Text;

                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                    if (cantidad > 0)
                    {
                        existe = true; // El nombre de usuario ya existe en la base de datos.
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Manejar la excepción específica de SQLite
                MessageBox.Show("Error al verificar la existencia del nombre de usuario en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                MessageBox.Show("Se produjo un error al intentar verificar la existencia del nombre de usuario: " + ex.Message);
            }

            return existe;
        }
    }
}