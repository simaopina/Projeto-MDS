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
        public int consultaSelected = 0;
        List<Consulta> ListaConsulta;
        List<Medico> ListaMedico;
         
        public Remarcar_consulta()
        {
            InitializeComponent();

            List<Consulta> ListaConsulta = new List<Consulta>();
            List<Medico> ListaMedico = new List<Medico>();


            cbxMedico.Items.AddRange(ListaMedico.ToArray());
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
            /* string nome_paciente = tbxNomepaciente.Text;
             DateTime dia = dateTiDia.Value;
             DateTime hora = dateTHora.Value;
             string especialidade = cbxEspecialidade.Text;
             string medico = cbxMedico.Text;*/

            consultaSelected = listVRemarcar.SelectedItems[0].Index;

            if (consultaSelected != -1)
            {
            ListaConsulta[consultaSelected].Nome_Paciente = tbxNomepaciente.Text;
            ListaConsulta[consultaSelected].Hora = dateTHora.Value;
            ListaConsulta[consultaSelected].Dia = dateTiDia.Value;
            ListaConsulta[consultaSelected].Especialidade = cbxEspecialidade.Text;
            ListaConsulta[consultaSelected].Medico = cbxMedico.Text;

                RefreshListaConsultas();
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
                consultaSelected = listVRemarcar.SelectedItems[0].Index;

                tbxNomepaciente.Text = ListaConsulta[consultaSelected].Nome_Paciente.ToString();
                dateTHora.Value = ListaConsulta[consultaSelected].Hora;
                dateTiDia.Value = ListaConsulta[consultaSelected].Dia;
                cbxEspecialidade.Text = ListaConsulta[consultaSelected].Especialidade.ToString();
                cbxMedico.Text = ListaConsulta[consultaSelected].Medico.ToString();

            }
        }

        private void RefreshListaConsultas()
        {
            listVRemarcar.Items.Clear();

            foreach (Consulta consulta in ListaConsulta)
            {
                ListViewItem item = new ListViewItem(consulta.Nome_Paciente);
                item.SubItems.Add(consulta.Dia.ToShortDateString());
                item.SubItems.Add(consulta.Hora.ToShortTimeString());
                item.SubItems.Add(consulta.Especialidade);
                item.SubItems.Add(consulta.Medico.ToString());



                listVRemarcar.Items.Add();
                
            }
        }

        private void Remarcar_consulta_Load(object sender, EventArgs e)
        {
            RefreshListaConsultas();
        }
    }
}
