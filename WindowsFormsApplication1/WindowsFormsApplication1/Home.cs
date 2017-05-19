using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnInserirMedico_Click(object sender, EventArgs e)
        {
            Inserir_Medico Ifrm = new Inserir_Medico();
            Ifrm.Show();
            Hide();
        }

        private void btnMarcarConsulta_Click(object sender, EventArgs e)
        {
            Marcar_consulta F1frm = new Marcar_consulta();
            F1frm.Show();
            Hide();
        }

        private void btnRemarcarConsultas_Click(object sender, EventArgs e)
        {
            Remarcar_consulta F2frm = new  Remarcar_consulta();
            F2frm.Show();
            Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
