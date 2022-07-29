using SSX_Xbox_Modder.FileHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSX_Xbox_Modder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TrickyMXFModelHandler trickyMXF = new TrickyMXFModelHandler();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Model File (*.mxf)|*.mxf|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = false
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                trickyMXF = new TrickyMXFModelHandler();
                trickyMXF.load(openFileDialog.FileName);
            }
        }
    }
}
