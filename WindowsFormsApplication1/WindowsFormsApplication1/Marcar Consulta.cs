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
    public partial class Marcar_consulta : Form
    {

        List<Consulta> ListaConsulta;

        public BasemdsEntities container = new BasemdsEntities();

        int consultaSelecionada = -1;

        public Marcar_consulta()
        {
            InitializeComponent();


           ListaConsulta = new List<Consulta>();

            List<Medico> listMedico = container.MedicoSet.ToList();

            foreach (Consulta consulta in ListaConsulta)
            {
                ListViewItem ItemConsulta = new ListViewItem(consulta.nome_paciente);
                ItemConsulta.SubItems.Add(consulta.dia.ToShortDateString());
                ItemConsulta.SubItems.Add(consulta.hora.ToShortTimeString());
                ItemConsulta.SubItems.Add(consulta.especialidade);
                ItemConsulta.SubItems.Add(consulta.Medico.nome.ToString());

                listVConsultas.Items.Add(ItemConsulta);
            }


            foreach (Medico pmedico in listMedico)
            {
                cmbMedico.Items.Add(pmedico.Id.ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            DateTime dia = dateTimeDia.Value;
            DateTime hora = dateTimeHora.Value;
            string especialidade = cmbEsp.SelectedItem.ToString();
            int medico = Convert.ToInt32(cmbMedico.Text);

            if (consultaSelecionada == -1)
            {
                Consulta list = new Consulta {
                    nome_paciente = nome,
                    dia = dia,
                    hora = hora,
                    especialidade = especialidade,
                    MedicoId  = medico
                                
                    
                };


                ListaConsulta.Add(list);

                RefreshCampos();

                RefreshListaConsulta();

            }


        }


        public void RefreshCampos()
        {
            txtNome.ResetText();
            dateTimeDia.Value = DateTime.Now;
            dateTimeHora.Value = DateTime.Now;
            cmbEsp.SelectedIndex = -1;
            cmbMedico.ResetText();
        }


        private void RefreshListaConsulta()
        {
            listVConsultas.Items.Clear();

            foreach (Consulta list in ListaConsulta)
            {
                listVConsultas.Items.Add(list.ToString());
            }
        }

        private void listVConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

