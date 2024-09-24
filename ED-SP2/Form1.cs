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
    public partial class Form1 : Form
    {
        // declarar el objeto a usar con la estructura Cola:
        Cola salaEspera = new Cola();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // inicializar la interfaz
            lstPacientes.Items.Clear();
        }

        //AGREGAR 
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            Nodo nuevo = form2.Paciente; // Traemos los datos almacenados en paciente del form2

            if(nuevo != null)
            { 
                //Controlamos que no se repitan, con el metodo de buscar
                if (!salaEspera.Buscar(nuevo.NroHistoriaClinica))
                { 
                salaEspera.Ingresar(nuevo);
                MostrarPacientes();
                }
                else
                {
                    // Si ya existe, muestra un mensaje de advertencia
                    MessageBox.Show("Ya existe un paciente con el mismo número de Historia Clínica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        
        
        //ELIMINAR
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            // paciente viene del form2 
            Nodo paciente = salaEspera.Eliminar();


            MessageBox.Show("El paciente " + paciente.Nombre + " Fue eliminado");
            MostrarPacientes();

        }

        //MOSTRAR TODOS Muestra los datos de todos los pacientes en espera
        private void MostrarPacientes()
        {
            List<Nodo> pacientes = salaEspera.Listar();


            lstPacientes.Items.Clear();


            // recorrer la coleccin de nodos y mostrar sus datos en el listBox
            foreach (Nodo paciente in pacientes)
            {
                lstPacientes.Items.Add(paciente.NroHistoriaClinica.ToString() +
                    "   " + paciente.Apellido + " " + paciente.Nombre);
            }

        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }
    }
}
