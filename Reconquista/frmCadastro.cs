using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconquista
{
    public partial class frmCadastro : MetroFramework.Forms.MetroForm
    {
        public frmCadastro()
        {
            InitializeComponent();            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == 0)
            {
                lblRGIE.Text = "R.G.";
                lblCPFCPNJ.Text = "C.P.F.";
                mtbRGIE.Text = "";
                mtbCPFCNPJ.Text = "";                
            }        
            if (metroComboBox1.SelectedIndex == 1) {
                lblRGIE.Text = "Inscrição Estadual";
                lblCPFCPNJ.Text = "C.N.P.J";
                mtbRGIE.Text = "";
                mtbCPFCNPJ.Text = "";
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = 0;
            metroTabControl1.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 1;
        }
    }
}
