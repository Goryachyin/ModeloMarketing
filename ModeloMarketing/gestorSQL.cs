using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace ModeloMarketing
{

    internal class gestorSQL
    {
        static string server = "localhost";
        static string database = "marketing_tec";
        static string user = "root";
        static string password = "";
        string connection = $"server={server};Database={database};User Id={user};password={password}";

        string default_profile = "0x89504e470d0a1a0a0000000d4948445200000080000000800806000000c33e61cb0000037f49444154785ee" +
            "d9d4b6e1c31104367ae93a3f8c0394aaed301b2b3030c51a8668b523d6ff5819a7c4d9564cff87d5dd7f5e267ac026f0018ebfdbf07078" +
            "0d9fe03c070ff01000028024733400d30da7e8ac0e1f6030000700f309b016a80d9fe730c1cee3f000000f700a319a006186d3fc7c0e1f" +
            "6030000700f309b016a80d9fe730c1cee3f000000f700a319a006186d3fc7c0e1f6030000700f309b016a80d9fe730c1cee3f000000f70" +
            "0a319a006186d3fc7c0e1f61f08c0fbd76faba9d79f2febfc4f4f7edc160000358400a0a6d78b04280af6747712a0a6f8f609e0365cc9b" +
            "97b2200807258b4034053c0ee7012a0a72009d0d36ffba2703b0056bff18a97ddb60400508e16db01a02858b53b095055ec737f12e05e3" +
            "db7ab09e201487fe3153fe95b020028079bed00d0149004680a288693005e7de36b02000080ec7f18c116e0259404f0eacb16d0d59704e" +
            "82ab8f945100000805701f3ecdc03340526019a02720fe01550cd4e02288514a1e6bff36f2e4f0e07002991a85201a0a920a700ab806a7" +
            "2124029c416d054a8379c9bc09e7e7234092025a206684ad41a4e02b4e4d3834900add1c71e5c043505543556fad7c4010000781530cfc" +
            "e16d0149804680ac816e01550cd4e0228858aede989906ef84fb9e38f81ff2d38fc770300507ca3abdd4980aa62e2a22dfd184802dc6bf" +
            "8f65b401a10bb453e00dcfc4201c0cd8256a75b5d130040d5b19bfb03404fd0ed8e81ea71dd40ecfec61f57033c5d1402807a0517b7930" +
            "03503d8026a7ac57fd8b3f838fccfa0aa60a7f53f2e014e33c8fd3c00e056387c7e000837c8bdbce300e014504306006a7a710a28eaf57" +
            "87712a026390950d38b0428ea757b77f71bde5df06e57c5db2500007411fd3e1e00eed573bb2d02000020ebab62d323becb4b5a8d10970" +
            "000d045ac361e006a7ab57b9300424212a0cd586982e50970bae1ca8dd5890000ca21733b00847fd8d3ecfff27b0312c0edb0989f04200" +
            "1962248022c95ffc516c029e06b298224c052f90726c0f4375ef1f67451f8780200c067040040bd2287b703c0e106abc70300a5d0e1ed0" +
            "070b8c1eaf100402974783b001c6eb07abce300e0d8a72c5f7b2cb4df03000000f414183edabd259000e1800140b841eee501805be1f0f" +
            "90120dc20f7f200c0ad70f8fc00106e907b7900e056387c7e000837c8bd3c00702b1c3e3f00841be45e1e00b8150e9f1f00c20d722f0f0" +
            "0dc0a87cfef06e02f47fc12ae4d2f1f9d0000000049454e44ae4260820000";

        public bool registrarCliente(string nombre, string noControl, string correo, string password, string fecha, string carrera, byte[] imagenNueva)
        {
            bool valor = false;
            byte[] imagenData;

            if (imagenNueva != null)
            {
                imagenData = imagenNueva;
            }
            else
            {
                string hexaString = default_profile.Substring(2);
                imagenData = Enumerable.Range(0, hexaString.Length / 2)
                    .Select(x => Convert.ToByte(hexaString.Substring(x * 2, 2), 16))
                    .ToArray();
            }

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                try
                {

                    con.Open();
                    string consulta = "INSERT INTO usuario(id_usuario,nombre_usuario,correo_usuario,password_usuario,fecha_usuario,carrera_usuario, imagen_usuario) VALUES " +
                        "(@id_usuario,@nombre_usuario,@correo_usuario,@password_usuario,@fecha_usuario,@carrera_usuario,@imagenData)";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", noControl);
                        cmd.Parameters.AddWithValue("@nombre_usuario", nombre);
                        cmd.Parameters.AddWithValue("@correo_usuario", correo);
                        cmd.Parameters.AddWithValue("@password_usuario", password);
                        cmd.Parameters.AddWithValue("@fecha_usuario", fecha);
                        cmd.Parameters.AddWithValue("@carrera_usuario", carrera);
                        cmd.Parameters.Add("@imagenData", MySqlDbType.LongBlob).Value = imagenData;

                        try
                        {
                            //Inserción de datos
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Datos registrados existosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                valor = true;
                            }
                            
                        }
                        catch(MySqlException sqlex)
                        {
                            MessageBox.Show("Imagen demasiado pesada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("No se pudo hacer conexión a la BD \n");
                }
                return valor;
            }
        }

        public bool loginGeneral(string user, string password)
        {

            using (MySqlConnection cn = new MySqlConnection(connection))
            {
                bool valor = false;
                try
                {
                    cn.Open();
                    string consulta = "SELECT * FROM usuario WHERE id_usuario = @user AND password_usuario = @password";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@password", password);
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    valor = true;
                                }
                            }
                            return valor;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al verificar el usuario " + ex);
                    return valor;
                }
            }
        }

        public void subirImagen()
        {
            using (MySqlConnection cn = new MySqlConnection(connection))
            {
                cn.Open();
                OpenFileDialog fileDialog = new OpenFileDialog();

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] imagenData = File.ReadAllBytes(fileDialog.FileName);

                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `imagen` (`imagen`, `nombre`) VALUES (@imagenData, @nombre)",cn))
                    {
                        
                        cmd.Parameters.Add("@imagenData", MySqlDbType.LongBlob).Value = imagenData;
                        cmd.Parameters.AddWithValue("@nombre", fileDialog.SafeFileName);


                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void cargarImagen(PictureBox foto, string idUser)
        {

            using (MySqlConnection cn = new MySqlConnection(connection))
            {
                cn.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT imagen_usuario FROM `usuario` WHERE id_usuario = @idUser", cn))
                {
                    command.Parameters.AddWithValue("@idUser",idUser);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())

                    {
                        byte[] imageData = (byte[])reader["imagen_usuario"];
                        MemoryStream ms = new MemoryStream(imageData);
                        foto.Image = Image.FromStream(ms);
                        foto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    reader.Close();
                    cn.Close();
                }
            }
        }

        public void cargarPerfil(string idUser, PictureBox foto, Label lbNombre, Label lbCarrera)
        {
            string[] dataUser;
            using (MySqlConnection cn = new MySqlConnection(connection))
            {
                cn.Open();
                string consulta = "SELECT * FROM `usuario` WHERE id_usuario = @idUser";

                using (MySqlCommand cmd = new MySqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@idUser",idUser);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet();
                        da.Fill(dataSet);

                        DataTable dataTable = dataSet.Tables[0];
                        dataUser = new string[dataTable.Columns.Count];

                        foreach (DataRow row in dataTable.Rows)
                        {
                            for (int i = 0; i < dataUser.Length; i++)
                            {
                                dataUser[i] = row[i].ToString();
                            }
                        }
                    }
                }
            }

            lbNombre.Text = dataUser[1];
            lbCarrera.Text = dataUser[5];
            cargarImagen(foto,idUser);
        }

        public bool cargarProducto(byte[] imagen, string nombre, string precio, string disponibilidad,string descripcion, string categoria, string tipo, string size)
        {
            GestorDir gestorDir = new GestorDir();

            string id_vendedor = gestorDir.buscarValorKey("usuario");
            bool verificado = false;
            using(MySqlConnection cn = new MySqlConnection(connection))
            {
                cn.Open();
                string consulta = "INSERT INTO `producto` (`ID_PRO`, `ID_VENDEDOR`, `NOMBRE_P`, `PRECIO_P`, `DISPONIBILIDAD_P`, `DESCRIPCION_O`, `CATEGORIA_P`, `TIPO_P`, `TAMAÑO_P`, `IMAGEN_P`) " +
                    "VALUES (NULL, @id_vendedor, @nombre, @precio, @disponibilidad, @descripcion, @categoria, @tipo, @size, @imagen)";
                using (MySqlCommand cmd = new MySqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@id_vendedor", id_vendedor);
                    cmd.Parameters.AddWithValue("@nombre",nombre);
                    cmd.Parameters.AddWithValue("@precio",precio );
                    cmd.Parameters.AddWithValue("@disponibilidad", disponibilidad);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.AddWithValue("categoria", categoria);
                    cmd.Parameters.AddWithValue("tipo", tipo);
                    cmd.Parameters.AddWithValue("size", size);
                    cmd.Parameters.Add("@imagen", MySqlDbType.LongBlob).Value = imagen;

                    try
                    {
                        //Inserción de datos
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos registrados existosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            verificado = true;
                        }
                    }
                    catch (MySqlException sqlex)
                    {
                        MessageBox.Show("Error al registrar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            return verificado;
        }

        public void cargarProductosEnPerfil(string id, GroupBox gb)
        {
            int numFilas = 1;
            int coordY = 35;
            using (MySqlConnection cn = new MySqlConnection(connection))
            {
                cn.Open();
                string consulta = "SELECT `IMAGEN_P` FROM `producto` WHERE ID_VENDEDOR = @id;";
                using(MySqlCommand cmd = new MySqlCommand(consulta,cn))
                {
                    cmd.Parameters.AddWithValue("@id",id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        //int[] coordenadasX = { 18, 127, 235 };

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                if(numFilas == 1)
                                {
                                    intento(gb, "IMAGEN_P",  reader, 18, coordY);
                                    ///MessageBox.Show("Imagen1");
                                }else if(numFilas == 2)
                                {
                                    intento(gb, "IMAGEN_P", reader, 127,coordY);
                                    //MessageBox.Show("Imagen2");
                                }
                                else if(numFilas == 3)
                                {
                                    intento(gb, "IMAGEN_P", reader, 235, coordY);
                                    //MessageBox.Show("Imagen3");
                                }
                                else
                                {
                                    coordY += 100;
                                    numFilas = 1;
                                    //MessageBox.Show("Reset");
                                    intento(gb, "IMAGEN_P", reader, 18, coordY);
                                }
                                numFilas++;
                            }

                            
                        }



                    }
                }
            }
            
        }

        public void intento(GroupBox gb, string imagen, MySqlDataReader reader, int x, int y)
        {
            Panel panel01 = new Panel();
            PictureBox foto1 = new PictureBox();

            // 
            // panel01
            // 
            panel01.BackColor = Color.FromArgb(236, 236, 236);
            panel01.Controls.Add(foto1);
            panel01.Location = new Point(x, y);
            panel01.Name = "panel01";
            panel01.Size = new Size(103, 95);
            panel01.TabIndex = 15;
            gb.Controls.Add(panel01);
            // 
            // foto1
            // 
            foto1.BackgroundImageLayout = ImageLayout.Zoom;
            foto1.Location = new Point(11, 11);
            foto1.Name = "foto1";
            foto1.Size = new Size(80, 75);
            foto1.TabIndex = 0;
            foto1.TabStop = false;

            byte[] imageData = (byte[])reader[imagen];
            MemoryStream ms = new MemoryStream(imageData);
            foto1.Image = Image.FromStream(ms);
            foto1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
