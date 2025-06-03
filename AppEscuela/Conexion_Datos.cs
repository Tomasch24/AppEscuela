using System;

using Microsoft.Data.SqlClient;

namespace CapaDatos
{



    public class Persona
    {
        //atributos de la clase persona para ser heredados en otras clases
        public int ID;
        public string Nombre;
        public string Apellido;
        public string Tipo;
    }

    //clase estudiante para heredar de la clase persona sus atributos

    public class Estudiante : Persona
    {
        public string carrera = "Ingenieria en Software";
    
    }

    //clase Docente para heredar de la clase persona sus atributos
    public class Docente : Persona
    {
        public string Materia = "Programacion";
    }

    public class PersonaDatos
    {
        //cadena de conexion
        public string conexion = "Server=.;Database=Escuela;Integrated Security=true" + ";TrustServerCertificate=True";

        //Metodo para buscar una persona por su id
        public Persona ObtenerPersonaPorId(int idBusqueda)
        {
            //Se abre la conexion
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();//abre la conexion a la base de datos

                string query = "SELECT * From Persona Where id = @Id";

                //Comando SQL

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idBusqueda); // Agrega el parametro de busqueda

                //Ejecuta la consulta
                SqlDataReader reader = cmd.ExecuteReader();

                //Verifica si hay resultados
                if (reader.Read())
                {
                    //Se determina el tipo de persona

                    string Tipo = reader["Tipo"].ToString();
                    Persona persona;

                    //Si es Estudiante, se instancia Estudiante
                    if (Tipo == "Estudiante")
                        persona = new Estudiante();
                    else
                        //Si es Docente, se instancia Docente
                        persona = new Docente();

                    //Se asignan valores desde la base de datos a los atributos de clase
                    persona.ID = (int)reader["Id"];
                    persona.Nombre = reader["Nombre"].ToString();
                    persona.Apellido = reader["Apellido"].ToString();
                    persona.Tipo = Tipo;

                    return persona; //Devuelve la persona encontrada
                }

                return null; //Si no encuentra nada, no devuelve nada
            }
        }
    }
}
