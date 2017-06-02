using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class Remarcar_consultaTests
    {
       
        [TestMethod()]
        public void Remarcar_ConsultaTest()
        {
            Remarcar_consulta remarcarConsulta = new Remarcar_consulta();
            remarcarConsulta.container = new DiagramaMDSContainer1();

            string nome_paciente = "Carlos Ribeiro";
            DateTime dia = DateTime.Now;
            DateTime hora = DateTime.Now;
            string especialidade = "Oftalmologia";
            Medico medico = new Medico() {
                nome = "Alberto Jardim",
                especialidade = "Oftalmologia",
                nif = 777777777,
                hora_inicio = DateTime.Now,
                hora_fim = DateTime.Now.AddHours(9)
        };

            DateTime data = Convert.ToDateTime("12/12/2017");
            Consulta consulta = new Consulta { nome_paciente = "antonio", especialidade = "Psicologia", dia = data, hora = Convert.ToDateTime("14:00:00"), MedicoId = 1 };


            remarcarConsulta.consultaSelected = consulta;


            //1. criar a consulta
            //2. atribuir a consulta criada ao consultaSelected
           
            Assert.IsTrue(remarcarConsulta.RemarcarConsulta(nome_paciente, dia, hora, especialidade, medico));

            // Assert.Fail();
        }


    }
}