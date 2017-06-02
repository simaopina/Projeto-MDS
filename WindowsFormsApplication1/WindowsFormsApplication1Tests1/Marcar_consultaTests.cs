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
        public void MarcarConsultaTest()
        {
            DateTime data = Convert.ToDateTime("12/12/2017");
            Consulta consulta = new Consulta { nome_paciente = "antonio", especialidade = "Psicologia", dia = data , hora = Convert.ToDateTime("14:00:00"), MedicoId = 1 };

            if (DateTime.Compare(data, DateTime.Now) <= 0)
            {
             Assert.Fail();
            }
        }


        //fazer outravez mas para nao passar!!!!
        [TestMethod()]
        public void MarcarConsultaTest1()
        {
            DateTime data = Convert.ToDateTime("12/12/2016");
            Consulta consulta = new Consulta { nome_paciente = "antonio", especialidade = "Psicologia", dia = data, hora = Convert.ToDateTime("14:00:00"), MedicoId = 1 };

            if (DateTime.Compare(data, DateTime.Now) >= 0)
            {
                Assert.Fail();
            }
        }
    }
}