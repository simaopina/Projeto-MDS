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
        public BasemdsEntities container = new BasemdsEntities();
        public int consultaSelected = 0;
     
        public Remarcar_consulta()
        {
            InitializeComponent();
            List<Medico> ListaMedico = container.MedicoSet.ToList();


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

        private void Remarcar_consulta_Load(object sender, EventArgs e)
        {
            RefreshListaConsultas();
        }
    }
}
