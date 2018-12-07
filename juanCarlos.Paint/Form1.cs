using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juanCarlos.Paint
{
    public partial class Form1 : Form
    {
        private int contador = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiHijo mdi = new MiHijo()
            {
                Text = $"Hijo {contador++}",
                MdiParent = this
            };

            mdi.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                
                if (sfdSave.ShowDialog() == DialogResult.OK)
                {
                    ((MiHijo)ActiveMdiChild).unobitMap.Save(
                        //@"C:\Users\Avantica\Desktop\img_" + sfdSave.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png
                        sfdSave.FileName, System.Drawing.Imaging.ImageFormat.Png
                        );
                    MessageBox.Show("Se guardó correctamente", "Save");
                }
            }
        }
    }
}
