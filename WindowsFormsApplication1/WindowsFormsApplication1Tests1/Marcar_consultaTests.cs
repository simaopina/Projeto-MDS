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
            DateTime data = Convert.ToDateTime("12/12/2016");
            Consulta consulta = new Consulta { nome_paciente = "antonio", especialidade = "Psicologia", dia = data , hora = Convert.ToDateTime("14:00:00"), MedicoId = 1 };

            if (DateTime.Compare(data, DateTime.Now) <= 0)
            {
             Assert.Fail();
            }
        }
    }
}