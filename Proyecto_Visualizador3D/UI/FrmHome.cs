using Proyecto_Visualizador3D.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Visualizador3D
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            homeToolStripMenuItem.ForeColor= Color.FromArgb(30, 30, 30);
        }

        private void conoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmCone frm = new FrmCone())
            {
                frm.ShowDialog();
            }

            this.Close();
        }

        private void cilindroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmCylinder frm = new FrmCylinder())
            {
                frm.ShowDialog();
            }

            this.Close();
        }

        private void cuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmCube frm = new FrmCube())
            {
                frm.ShowDialog();
            }

            this.Close();
        }

        private void pirámideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmPyramid frm = new FrmPyramid())
            {
                frm.ShowDialog();
            }

            this.Close();
        }

        private void esféaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmSphere frm = new FrmSphere())
            {
                frm.ShowDialog();
            }

            this.Close();
        }
    }
}
