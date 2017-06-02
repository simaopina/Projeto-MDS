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
    public class Marcar_consultaTests
    {
        [TestMethod()]
        public void Marcar_consultaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void carregarDadosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RefreshCamposTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MarcarConsultaTest()
        {
            Consulta consulta = new Consulta { nome_paciente = "antonio", especialidade = "Psicologia", dia = Convert.ToDateTime("12/12/2016"), hora = Convert.ToDateTime("14:00:00"), MedicoId = 1 };

            Assert.Fail();
        }
    }
}