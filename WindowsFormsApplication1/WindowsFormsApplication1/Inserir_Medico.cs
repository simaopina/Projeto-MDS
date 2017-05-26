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
        private List<Medico> ListaMedico;

        public Inserir_Medico()
        {
            InitializeComponent();
            ListaMedico = new List<Medico>();
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string Nome = tbxNome.Text;
            string Especialidade = cbxEspecialidade.Text;
            int NIF = Convert.ToInt32(tbxNIF.Text);
            DateTime Inicio = datetimeInicio.Value;
            DateTime Fim = datetimeFim.Value;

            Medico medico = new Medico
            (
                Nome,
                Especialidade,
                NIF,
                Inicio,
                Fim
            );
            ListaMedico.Add(medico);

            RefreshCampos();
        }

        private void RefreshCampos()
        {
            tbxNome.ResetText();
            cbxEspecialidade.SelectedIndex = -1;
            tbxNIF.ResetText();
            datetimeInicio.ResetText();
            datetimeFim.ResetText();
        }

        private void RefreshListaMedicos()
        {
            listVMedico.Items.Clear();

            foreach (Medico medico in ListaMedico)
            {
                listVMedico.Items.Add(medico.ToString());
            }
        }

        private void btnGerir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este botão não tem evento, visto que pretence a outro caso de uso!");
        }
    }
}
