using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFebreroDavid
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        Asignatura asig1 = new Asignatura();
        Asignatura asig2 = new Asignatura();
        Asignatura asig3 = new Asignatura();
        Asignatura asig4 = new Asignatura();

        public class Asignatura
        {
            string nombre;
            string dni;
            string aprendizaje;
            string interes;
            string fecha;
            bool consentimiento;
            string asistencia;
            string comentario;

            public void setDatos(string nombre, string dni, string aprendizaje, string interes, string fecha, bool consentimiento, string asistencia, string comentarios)
            {
                this.nombre = nombre;
                this.dni = dni;
                this.aprendizaje = aprendizaje;
                this.interes = interes;
                this.fecha = fecha;
                this.consentimiento = consentimiento;
                this.asistencia = asistencia;
                this.comentario = comentarios;
            }

            public void getDatos()
            {
                MessageBox.Show("Nombre: " + nombre
                                + "\nDNI: " + dni
                                + "\nAprendizaje: " + aprendizaje
                                + "\nInterés: " + interes
                                + "\nFecha: " + fecha
                                + "\nConsentimiento: " + consentimiento
                                + "\nAsistencia: " + asistencia
                                + "\nComentarios: " + comentario, "DATOS:", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = mensaje();
            if(resultado == DialogResult.Yes)
            {
                string aprender;
                if (radioButton1.Checked)
                {
                    aprender = "He aprendido mucho";
                }else if (radioButton2.Checked)
                {
                    aprender = "He aprendido poco";
                }else if (radioButton3.Checked)
                {
                    aprender = "No quiero aprender";
                }
                else
                {
                    aprender = "No quiero contestar";
                }
                asig1.setDatos(textBox3.Text, textBox2.Text, aprender, comboBox1.Text, maskedTextBox1.Text, checkBox1.Checked, listBox1.Text, textBox1.Text);
            }else if(resultado == DialogResult.No)
            {
                asig1.getDatos();
            }
            else
            {

            }
        }

        public DialogResult mensaje()
        {
            DialogResult res = MessageBox.Show("¿Quieres guardar los datos?", "INSERCIÓN DE DATOS", MessageBoxButtons.YesNoCancel);
            return res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = mensaje();
            if (resultado == DialogResult.Yes)
            {
                string aprender;
                if (radioButton1.Checked)
                {
                    aprender = "He aprendido mucho";
                }
                else if (radioButton2.Checked)
                {
                    aprender = "He aprendido poco";
                }
                else if (radioButton3.Checked)
                {
                    aprender = "No quiero aprender";
                }
                else
                {
                    aprender = "No quiero contestar";
                }
                asig2.setDatos(textBox3.Text, textBox2.Text, aprender, comboBox1.Text, maskedTextBox1.Text, checkBox1.Checked, listBox1.Text, textBox1.Text);
            }
            else if (resultado == DialogResult.No)
            {
                asig2.getDatos();
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = mensaje();
            if (resultado == DialogResult.Yes)
            {
                string aprender;
                if (radioButton1.Checked)
                {
                    aprender = "He aprendido mucho";
                }
                else if (radioButton2.Checked)
                {
                    aprender = "He aprendido poco";
                }
                else if (radioButton3.Checked)
                {
                    aprender = "No quiero aprender";
                }
                else
                {
                    aprender = "No quiero contestar";
                }
                asig3.setDatos(textBox3.Text, textBox2.Text, aprender, comboBox1.Text, maskedTextBox1.Text, checkBox1.Checked, listBox1.Text, textBox1.Text);
            }
            else if (resultado == DialogResult.No)
            {
                asig3.getDatos();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resultado = mensaje();
            if (resultado == DialogResult.Yes)
            {
                string aprender;
                if (radioButton1.Checked)
                {
                    aprender = "He aprendido mucho";
                }
                else if (radioButton2.Checked)
                {
                    aprender = "He aprendido poco";
                }
                else if (radioButton3.Checked)
                {
                    aprender = "No quiero aprender";
                }
                else
                {
                    aprender = "No quiero contestar";
                }
                asig4.setDatos(textBox3.Text, textBox2.Text, aprender, comboBox1.Text, maskedTextBox1.Text, checkBox1.Checked, listBox1.Text, textBox1.Text);
            }
            else if (resultado == DialogResult.No)
            {
                asig4.getDatos();
            }
            else
            {

            }
        }
    }
}
