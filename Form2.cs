using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSemana2Herramientas_Programacion_01
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Formulario Dos";
        }

        private void frm2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiciste click en el formulario");
        }
    }
}
