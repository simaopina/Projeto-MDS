using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Inserir_Medico : Form
    {
       
         public BasemdsEntities container ;

        public Inserir_Medico()
        {
            InitializeComponent();
            //List<Medico> ListaMedico = container.MedicoSet.ToList();
            container = new BasemdsEntities();

            foreach (Medico medico in container.MedicoSet)
            {
                ListViewItem ItemMedico = new ListViewItem(medico.nome);
                ItemMedico.SubItems.Add(medico.especialidade);
                ItemMedico.SubItems.Add(medico.nif.ToString());
                ItemMedico.SubItems.Add(medico.hora_inicio.ToShortTimeString());
                ItemMedico.SubItems.Add(medico.hora_fim.ToShortTimeString());

                listVMedico.Items.Add(ItemMedico);
            }
            
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

            Medico medico = new Medico()
            {
                nome = Nome,
                especialidade = Especialidade,
                nif = NIF,
                hora_inicio = Inicio,
                hora_fim = Fim

            };

            container.MedicoSet.Add(medico);
            RefreshCampos();
            RefreshListaMedicos();

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
            List<Medico> ListaMedico = container.MedicoSet.ToList();

            foreach (Medico medico in ListaMedico)
            {
                ListViewItem ItemMedico = new ListViewItem(medico.nome);
                ItemMedico.SubItems.Add(medico.especialidade);
                ItemMedico.SubItems.Add(medico.nif.ToString());
                ItemMedico.SubItems.Add(medico.hora_inicio.ToShortTimeString());
                ItemMedico.SubItems.Add(medico.hora_inicio.ToShortTimeString());

                listVMedico.Items.Add(ItemMedico);
            }
        }

        private void btnGerir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este botão não tem evento, visto que pretence a outro caso de uso!");
        }
    }
}
