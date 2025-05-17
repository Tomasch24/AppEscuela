using System;
using System.Drawing.Text;
using Capa_Negocios;
using CapaDatos;

namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarx_Click(object sender, EventArgs e)
        {
            //vamos a obtener el ID desde el txtbox

            int Id;

            if(!int.TryParse(txtID.Text, out Id))
            {
                MessageBox.Show("Ingrese un codigo Valido");
                return;
            }

            //Creamos una instancia de la capa de personas

            PersonaNegocios negocio = new PersonaNegocios();

            Persona persona = negocio.ObtenerPersona(Id);

            if (persona != null)
            {
                txtName.Text = persona.Nombre;
                txtApellido.Text = persona.Apellido;
                txtTipo.Text = persona.Tipo;

                if (persona is Estudiante est)
                {
                    txtExtra.Text = "Carrera " + est.carrera;
                }
                else if (persona is Docente prof)
                {
                    txtExtra.Text = "Materia " + prof.Materia;
                }
                else
                {
                    MessageBox.Show("Persona no encontrada");
                    LimpiarCampos();
                }
               
            }

        }

        private void LimpiarCampos() 
        {
            txtName.Text = "";
            txtApellido.Text = "";
            txtTipo.Text = "";
            txtExtra.Text = "";


        }


    }
}
