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
    public partial class Inserir_Medico : Form
    {
        private List<Medico> medicos;

        public Inserir_Medico()
        {
            InitializeComponent();
            medicos = new List<Medico>();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico
            {
                Nome = tbxNome.Text,
                Especialidade = cbxEspecialidade.Text,
                NIF = Convert.ToInt32(tbxNIF.Text),
                Inicio = datetimeInicio.Value,
                Fim = datetimeFim.Value
            };
            medicos.Add(medico);
        }
    }
}
