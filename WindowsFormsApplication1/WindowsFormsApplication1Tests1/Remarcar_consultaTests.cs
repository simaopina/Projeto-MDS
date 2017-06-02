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
            string medico = "Rita Almada";
            string especialidade = "Oftalmologia";
            DateTime Inicio = DateTime.Now;
            DateTime Fim = DateTime.Now;

            Assert.IsTrue(remarcarConsulta.Remarcarconsulta(nome_paciente, medico, especialidade, Inicio, Fim));

            // Assert.Fail();
        }
    }
}