using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_SP2
{
    public partial class Form2 : Form
    {
        // Propiedad para almacenar el nodo con los datos del paciente
        public Nodo Paciente { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtHC.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            { 

            Paciente = new Nodo(); //Se intansea unn nuevo nodo

                Paciente.Nombre = txtNombre.Text;
                Paciente.Apellido = txtApellido.Text;
                Paciente.NroHistoriaClinica=int.Parse(txtHC.Text);
            Close();
            
            }
            

        }

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    Paciente = null; // si se cancela el ingreso la propiedad Paciente queda null
        //    Close();
        //}


   
        //CONTROL DE DATOS INGRESADOS -  si falta alguno o el número de historia clínica es inválido
        private bool ValidarDatos()
        {
            bool Resultado = false; 

            //Si los datos no estan vacios entra
            if(txtHC.Text != "" && txtApellido.Text != "" && txtNombre.Text != "")
            {
                int numero = 0; 

                //validar si es un numero el ingresado 
                if(int.TryParse(txtHC.Text , out numero))
                {
                    return true;
                }


            }
            else //si estan vacios 
            {
                MessageBox.Show("Datos invalidos"); 
            }

           return Resultado;
       
        }
    }
}
