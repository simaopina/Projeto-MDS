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

        int consultaSelecionada = -1;

        public Marcar_consulta()
        {
            InitializeComponent();

            ListaConsulta = new List<Consulta>();

            foreach (Consulta consulta in ListaConsulta)
            {
                listVConsultas.Items.Add(consulta.ToString());
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
            string dia = dateTimeDia.Text;
            DateTime hora = dateTimeHora.Value;
            string especialidade = cmbEsp.SelectedItem.ToString();

            if (consultaSelecionada == -1)
            {
                Consulta list = new Consulta(
                    nome, 
                    dia, 
                    hora,
                    especialidade
                    );

                ListaConsulta.Add(list);

                RefreshCampos();

                RefreshListaConsulta();

            }


        }


        public void RefreshCampos()
        {
            txtNome.ResetText();
            //dateTimeDia.Value = DateTime.Now;
            dateTimeHora.Value = DateTime.Now;
            cmbEsp.SelectedIndex = -1;
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

