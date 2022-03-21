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
    public partial class Form2 : Form
    {
        bool mensaje = true;
        public Form2(bool aux)
        {
            InitializeComponent();
            mensaje = aux;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(mensaje == true)
            {
                label1.Visible = false;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
