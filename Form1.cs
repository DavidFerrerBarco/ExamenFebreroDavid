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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            bool aux = true;
            if(textBox1.Text == "" || maskedTextBox1.Text == "")
            {

            }
            else
            {
                if (textBox1.Text == "David")
                {
                    Form2 mensaje = new Form2(aux);
                    mensaje.ShowDialog();
                    this.Close();
                }
                else
                {
                    aux = false;
                    Form2 mensaje = new Form2(aux);
                    mensaje.ShowDialog();

                }
            }
            
        }
    }
}
