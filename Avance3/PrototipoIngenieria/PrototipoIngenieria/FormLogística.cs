using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrototipoIngenieria
{
    public partial class FormLogística : Form
    {
        public FormLogística()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void registrarContenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarContenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarContenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarContenedor frmDelCont = new EliminarContenedor();
            frmDelCont.Show();
        }

        private void registroDePiñaACámaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_en_camara frmRgCam = new Registrar_en_camara();
            frmRgCam.Show();
        }

        private void eliminarDeCámaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCámara frmDelCam = new EliminarCámara();
            frmDelCam.Show();
        }

        private void modificarDeCámaraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guíaDeDespachoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuíaDespacho frmGuia = new GuíaDespacho();
            frmGuia.Show();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCliente frmRegCliente = new RegistrarCliente();
            frmRegCliente.Show();
        }

        private void registrarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarContenedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            registrarContenedor frmRegcont = new registrarContenedor();
            frmRegcont.Show();
        }
    }
}
