using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamarindoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string usuario=textBox1.Text;
            string contra = textBox2.Text;
            if(usuario=="juancho"&&contra=="123tamarindo")
            {
                MessageBox.Show("Estas logeado");
                this.Close();
            }
            else
            {
                MessageBox.Show("No puedes acceder");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
