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
    public partial class Remarcar_consulta : Form
    {
        public DiagramaMDSContainer1 container = new DiagramaMDSContainer1();
        Consulta consultaSelected;
     
        public Remarcar_consulta()
        {
            InitializeComponent();

            List<Medico> ListaMedico = container.MedicoSet.ToList();

            // cbxMedico.Items.AddRange(ListaMedico.ToArray());
            carregarDados();
        }

        public void carregarDados()
        {
            List<Consulta> ListaConsulta = container.ConsultaSet.ToList();

            foreach (Consulta consulta in ListaConsulta)
            {
                //listVConsultas.Items.Clear();
                ListViewItem ItemConsulta = new ListViewItem(consulta.nome_paciente);
                ItemConsulta.SubItems.Add(consulta.dia.ToShortDateString());
                ItemConsulta.SubItems.Add(consulta.hora.ToShortTimeString());
                ItemConsulta.SubItems.Add(consulta.especialidade);
                ItemConsulta.SubItems.Add(consulta.MedicoId.ToString());

                listVRemarcar.Items.Add(ItemConsulta);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             string nome_paciente = tbxNomepaciente.Text;
             DateTime dia = dateTiDia.Value;
             DateTime hora = dateTHora.Value;
             string especialidade = cbxEspecialidade.Text;
            Medico medico = container.MedicoSet.Where(doc => doc.nome.Equals(cbxMedico.Text)).First();

            List<Consulta> ListConsulta = container.ConsultaSet.ToList();

            if (consultaSelected != null)
            {
                consultaSelected.nome_paciente = nome_paciente;
                consultaSelected.dia = dia;
                consultaSelected.hora = hora;
                consultaSelected.especialidade = especialidade;
                consultaSelected.Medico = medico;
                
carregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Não existe essa consulta. Se quiser inserir consultas novas dirija-se ao 'Marcar Consulta'");
            }
        }

        private void listVRemarcar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVRemarcar.SelectedItems != null)
            {

                string consultaU = listVRemarcar.SelectedItems[0].Text;
                consultaSelected = container.ConsultaSet.Where(cons => cons.nome_paciente.Equals(consultaU)).First();

                List<Consulta> ListConsulta = container.ConsultaSet.ToList();

                tbxNomepaciente.Text = consultaSelected.nome_paciente;
                cbxEspecialidade.Text = consultaSelected.especialidade;
                cbxMedico.Text = Convert.ToString(consultaSelected.Medico);
                dateTHora.Text = Convert.ToString(consultaSelected.hora);
                dateTiDia.Text = Convert.ToString(consultaSelected.dia);

                carregarDados();



            }
        }

        private void RefreshListaConsultas()
        {
            listVRemarcar.Items.Clear();

            List<Consulta> ListConsulta = container.ConsultaSet.ToList();

            foreach (Consulta consulta in ListConsulta)
            {
                ListViewItem item = new ListViewItem(consulta.nome_paciente);
                item.SubItems.Add(consulta.dia.ToShortDateString());
                item.SubItems.Add(consulta.hora.ToShortTimeString());
                item.SubItems.Add(consulta.especialidade);
                item.SubItems.Add(consulta.Medico.nome.ToString());



               // listVRemarcar.Items.Add();
                
            }
        }

        private void LimparCampos()
        {
            tbxNomepaciente.ResetText();
            cbxMedico.ResetText();
            cbxEspecialidade.ResetText();
            dateTHora.Value = DateTime.Now;
            dateTiDia.Value = DateTime.Now;
        }

        private void Remarcar_consulta_Load(object sender, EventArgs e)
        {
            //RefreshListaConsultas();
        }
    }
}
