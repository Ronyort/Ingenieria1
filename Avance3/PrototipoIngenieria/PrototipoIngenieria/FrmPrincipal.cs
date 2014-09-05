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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void registrarCantidadFrutaEntranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegsFrutaEntrante frmRegEnt = new RegsFrutaEntrante();
            frmRegEnt.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RProductor frmRproduct = new RProductor();
            frmRproduct.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EProductor frmEproduct = new EProductor();
            frmEproduct.Show();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MProductor frmMproduct = new MProductor();
            frmMproduct.Show();
        }

        private void facturaciónParaProductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            factPro frmFactPro = new factPro();
            frmFactPro.Show();
        }

        private void facturaciónParaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FactEmp frmFactEmp = new FactEmp();
            frmFactEmp.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RFrutaPlant frmFrutPl = new RFrutaPlant();
            frmFrutPl.Show();
        }

        private void eliminarCantidadDeFrutaEnPlantaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCorte frmCorte = new RCorte();
            frmCorte.Show();
        }

        private void registrarEstimaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REstimaciones frmEst = new REstimaciones();
            frmEst.Show();
        }

        private void insertarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REmpresa frmEmp = new REmpresa();
            frmEmp.Show();
        }

        private void modificarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MEmpresa frMemp = new MEmpresa();
            frMemp.Show();
        }

        private void eliminarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EEmpresa frmDelEmp = new EEmpresa();
            frmDelEmp.Show();
        }
    }
}
