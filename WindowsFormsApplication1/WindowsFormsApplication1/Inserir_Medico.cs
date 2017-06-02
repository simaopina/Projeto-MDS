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

        public DiagramaMDSContainer1 container = new DiagramaMDSContainer1();

        
        public Inserir_Medico()
        {
            InitializeComponent();
            
            // container = new BasemdsEntities();

            carregarDados();
            
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

      
        public void carregarDados()
        {

            List<Medico> ListaMedico = container.MedicoSet.ToList();
            
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



        private void btnInserir_Click(object sender, EventArgs e)
        {
            string Nome = tbxNome.Text;
            string Especialidade = cbxEspecialidade.Text;
            int NIF = Convert.ToInt32(tbxNIF.Text);
            DateTime Inicio = datetimeInicio.Value;
            DateTime Fim = datetimeFim.Value;

            if (InserirMedico(Nome, Especialidade, NIF, Inicio, Fim))
            {
                MessageBox.Show("Inserido");
            }
            else
            {
                MessageBox.Show("ERROOOOO");
            }
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

        public bool InserirMedico(string Nome, string Especialidade, int NIF, DateTime Inicio, DateTime Fim)
        {
            bool resultado;

            try
            {
                Medico medico = new Medico()
                {
                    nome = Nome,
                    especialidade = Especialidade,
                    nif = NIF,
                    hora_inicio = Inicio,
                    hora_fim = Fim

                };

                container.MedicoSet.Add(medico);
                container.SaveChanges();

                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
         
                //throw;
            }
            return resultado;
        }

        //----------------------------- teste unitário:
        /*testUnitInserirMedico()
        {
            Inserir_Medico insMedico = new Inserir_Medico();
            
            Assert.IsTrue(insMedico.InserirMedico('Joana', 'Dentista', 9146482646, 12/05/2012, 13/09/2016));
        }*/
    }
}
