using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        private LEstudiantes estudiante;
        public Form1()
        {
            InitializeComponent();

            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxNid);
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellido);
            listTextBox.Add(textBoxEmail);
            var listLabel = new List<Label>();
            listLabel.Add(labelNid);
            listLabel.Add(labelName);
            listLabel.Add(labelApellido);
            listLabel.Add(labelEmail);
            Object[] objectos = { pictureBoxImage };
            estudiante = new LEstudiantes(listTextBox,listLabel, objectos);
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.uploadimage.CargarImagen(pictureBoxImage);
        }

        private void textBoxNid_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNid.Text.Equals(""))
            {
                labelNid.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNid.ForeColor = Color.Green;
                labelNid.Text = "Nid";
            }
        }

        private void textBoxNid_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if(textBoxNombre.Text.Equals(""))
            {
                labelName.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelName.ForeColor = Color.Green;
                labelName.Text = "Nombre";
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if(textBoxApellido.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApellido.ForeColor = Color.Green;
                labelApellido.Text = "Apellido";
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if(textBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "Email";
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            estudiante.Registrar();
        }
    }
}
