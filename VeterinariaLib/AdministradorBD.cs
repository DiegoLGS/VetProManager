using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeterinariaLib
{
    public class AdministradorBD
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public int idGenerado;

        static AdministradorBD()
        {
            AdministradorBD.cadena_conexion = Properties.Resources.conexionVetProBD;
        }

        public AdministradorBD()
        {
            this.conexion = new SqlConnection(AdministradorBD.cadena_conexion);
        }

        public bool AgregarBD(Animal animal)
        {
            this.comando = this.ConfigurarParametros(animal);            
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.CommandText = "INSERT INTO animales (nombre, fecha_nacimiento, fecha_ingreso, especie, observaciones, historial_medico, nombre_responsable, apellido_responsable, dni_responsable) output INSERTED.ID VALUES (@nombre, @fecha_nacimiento, @fecha_ingreso, @especie, @observaciones, @historial_medico, @nombre_responsable, @apellido_responsable, @dni_responsable)";

            return EjecutarComando(this.comando, obtenerId : true);
        }

        public bool AgregarBD(Persona persona)
        {
            this.comando = this.ConfigurarParametros(persona);
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.CommandText = "INSERT INTO personas (nombre, apellido, dni, numero_contacto) VALUES (@nombre, @apellido, @dni, @numero_contacto)";

            return EjecutarComando(this.comando);
        }

        private SqlCommand ConfigurarParametros(Animal animal)
        {
            comando = new SqlCommand();
            comando.Parameters.AddWithValue("@nombre", animal.Nombre);
            comando.Parameters.AddWithValue("@fecha_nacimiento", animal.FechaNacimiento);
            comando.Parameters.AddWithValue("@fecha_ingreso", animal.FechaIngreso);
            comando.Parameters.AddWithValue("@especie", animal.Especie);
            comando.Parameters.AddWithValue("@observaciones", animal.Observaciones);
            comando.Parameters.AddWithValue("@historial_medico", animal.HistorialMedico);
            comando.Parameters.AddWithValue("@nombre_responsable", animal.NombreDelResponsable);
            comando.Parameters.AddWithValue("@apellido_responsable", animal.ApellidoDelResponsable);
            comando.Parameters.AddWithValue("@dni_responsable", animal.DniDelResponsable);

            return comando;
        }

        private SqlCommand ConfigurarParametros(Persona persona)
        {
            comando = new SqlCommand();
            comando.Parameters.AddWithValue("@nombre", persona.Nombre);
            comando.Parameters.AddWithValue("@apellido", persona.Apellido);
            comando.Parameters.AddWithValue("@dni", persona.Dni);
            comando.Parameters.AddWithValue("@numero_contacto", persona.NumeroContacto);

            return comando;
        }

        private bool EjecutarComando(SqlCommand comando, bool obtenerId = false)
        {
            bool respuesta = false;            
            int filasAfectadas = 1;

            try
            {
                comando.Connection = this.conexion;

                this.conexion.Open();

                if (obtenerId)
                {                        
                    this.idGenerado = Convert.ToInt32(comando.ExecuteScalar());
                }
                else
                {
                    filasAfectadas = comando.ExecuteNonQuery();                
                }

                if (filasAfectadas == 1)
                {                    
                    respuesta = true;

                }
                else
                {
                    throw new ComandoBDException("La ejecución del comando no afectó el número esperado de filas en la base de datos.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Se produjo un error con la base de datos: {sqlEx.Message}");
            }
            catch (ComandoBDException ex)
            {
                MessageBox.Show($"Error al ejecutar comando en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return respuesta;
        }

        public List<Animal> ObtenerListaAnimales()
        {
            ListaAnimales listaCargada = new ListaAnimales();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"SELECT nombre, fecha_nacimiento, fecha_ingreso, id, especie, observaciones, historial_medico, nombre_responsable, apellido_responsable, dni_responsable FROM animales";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {                    
                    Animal animal = new Animal(this.lector["nombre"].ToString(), (DateTime)this.lector["fecha_nacimiento"], (DateTime)this.lector["fecha_ingreso"], this.lector["especie"].ToString(), this.lector["observaciones"].ToString(), this.lector["historial_medico"].ToString(), this.lector["nombre_responsable"].ToString(), this.lector["apellido_responsable"].ToString(), (int)this.lector["dni_responsable"]);
                    animal.Id = (int)this.lector["id"];

                    _ = listaCargada + animal;
                }

                this.lector.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Error de SQL al obtener la lista de animales: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado al obtener la lista de animales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (this.conexion.State == System.Data.ConnectionState.Open)
                    {
                        this.conexion.Close();
                    }
                }

            return listaCargada.listaAnimalesActuales;
        }

        public List<Persona> ObtenerListaPersonas()
        {
            ListaPersonas listaCargada = new ListaPersonas();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"SELECT nombre, apellido, dni, numero_contacto FROM personas";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    Persona persona = new Persona(this.lector["nombre"].ToString(), this.lector["apellido"].ToString(), (int)this.lector["dni"], this.lector["numero_contacto"].ToString());

                    _ = listaCargada + persona;
                }

                this.lector.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL al obtener la lista de animales: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al obtener la lista de animales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return listaCargada.listaPersonasActuales;
        }

        public bool Eliminar(string tabla, string columna, int id)
        {
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.Connection = this.conexion;
                this.comando.Parameters.AddWithValue("@id", id);
                this.comando.CommandText = $"DELETE FROM {tabla} WHERE {columna} = @id";

                return EjecutarComando(this.comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar el registro de la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ModificarPorId(Animal animal, int id)
        {
            this.comando = this.ConfigurarParametros(animal);       
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.CommandText = $"UPDATE animales SET nombre = @nombre, fecha_nacimiento = @fecha_nacimiento, fecha_ingreso = @fecha_ingreso, especie = @especie, observaciones = @observaciones, historial_medico = @historial_medico, nombre_responsable = @nombre_responsable, apellido_responsable = @apellido_responsable, dni_responsable = @dni_responsable WHERE id = {id}";

            return EjecutarComando(this.comando);
        }

        public bool ModificarPorId(Persona persona, int id)
        {
            this.comando = this.ConfigurarParametros(persona);
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.CommandText = $"UPDATE personas SET nombre = @nombre, apellido = @apellido, dni = @dni, numero_contacto = @numero_contacto WHERE dni = {id}";

            return EjecutarComando(this.comando);
        }
    }
}
