﻿using System;
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

        Medico medicoselecionado = null;

        Consulta consultaSelecionada = null;

        public DiagramaMDSContainer1 container = new DiagramaMDSContainer1();

       // int consultaSelecionada = -1;

        public Marcar_consulta()
        {
            InitializeComponent();

            carregarDados();


            /*ListaConsulta = new List<Consulta>();

             List<Medico> listMedico = container.MedicoSet.ToList();

             foreach (Consulta consulta in ListaConsulta)
             {
                 ListViewItem ItemConsulta = new ListViewItem(consulta.nome_paciente);
                 ItemConsulta.SubItems.Add(consulta.dia.ToShortDateString());
                 ItemConsulta.SubItems.Add(consulta.hora.ToShortTimeString());
                 ItemConsulta.SubItems.Add(consulta.especialidade);
                 ItemConsulta.SubItems.Add(consulta.MedicoId.ToString());

                 listVConsultas.Items.Add(ItemConsulta);
             }

             RefreshListaConsulta();

             foreach (Medico pmedico in listMedico)
             {
                 cmbMedico.Items.Add(pmedico.nome);
             }*/


        }

        public void carregarDados()
        {

            List<Consulta> ListaConsulta = container.ConsultaSet.ToList();

            List<Medico> listMedico = container.MedicoSet.ToList();

            foreach (Consulta consulta in ListaConsulta)
            {
                listVConsultas.Items.Clear();
                ListViewItem ItemConsulta = new ListViewItem(consulta.nome_paciente);
                ItemConsulta.SubItems.Add(consulta.dia.ToShortDateString());
                ItemConsulta.SubItems.Add(consulta.hora.ToShortTimeString());
                ItemConsulta.SubItems.Add(consulta.especialidade);
                ItemConsulta.SubItems.Add(consulta.MedicoId.ToString());

                listVConsultas.Items.Add(ItemConsulta);
            }

           // RefreshListaConsulta();

            foreach (Medico pmedico in listMedico)
            {
                cmbMedico.Items.Add(pmedico.nome);
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

            List<Consulta> ListaConsulta = container.ConsultaSet.ToList();

            string nome = txtNome.Text;
            DateTime dia = dateTimeDia.Value;
            DateTime hora = dateTimeHora.Value;
            string especialidade = cmbEsp.SelectedItem.ToString();
            int medico = Convert.ToInt32(numericUpDown1.Value);

            //if (consultaSelecionada != null)
            //{
                Consulta list = new Consulta {
                    nome_paciente = nome,
                    dia = dia,
                    hora = hora,
                    especialidade = especialidade,
                    MedicoId  = medico              
                    
                };


                ListaConsulta.Add(list);
                container.SaveChanges();

                RefreshCampos();

                carregarDados();

            //}


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
            foreach (Consulta consulta in ListaConsulta)
            {
                ListViewItem ItemConsulta = new ListViewItem(consulta.nome_paciente);
                ItemConsulta.SubItems.Add(consulta.dia.ToShortDateString());
                ItemConsulta.SubItems.Add(consulta.hora.ToShortTimeString());
                ItemConsulta.SubItems.Add(consulta.especialidade);
                ItemConsulta.SubItems.Add(consulta.MedicoId.ToString());

                listVConsultas.Items.Add(ItemConsulta);
            }
        }

        private void listVConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedico.Items.Count > 0)
            {
                string medic = cmbMedico.Text;

                medicoselecionado = container.MedicoSet.Where(med => med.nome.Equals(medic)).First();

                List<Medico> medico = container.MedicoSet.ToList();

                numericUpDown1.Value = medicoselecionado.Id;
                
            }
        }
    }
}

