using CapaDatos;

namespace Capa_Negocios
{
    public class PersonaNegocios
    {
        //Aqui creamos una instancia de la clase  que accede a la base de datos
        private PersonaDatos datos = new PersonaDatos();

        //Este metodo sirve para obtener una persona por su Id

        public Persona ObtenerPersona(int Id)
        {

            return datos.ObtenerPersonaPorId(Id);
        }
    }
}
