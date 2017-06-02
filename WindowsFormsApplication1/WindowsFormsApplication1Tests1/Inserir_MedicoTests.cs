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
    public class Inserir_MedicoTests
    {
      
        [TestMethod()]
        public void InserirMedicoTest()
        {

            Inserir_Medico insMedico = new Inserir_Medico();
            insMedico.container = new DiagramaMDSContainer1();
            
            string Nome = "Ana Malhoa";
            string Especialidade = "Oftalmologia";
            int NIF = 215478596;
            DateTime Inicio = DateTime.Now;
            DateTime Fim = DateTime.Now.AddHours(5);

            Assert.IsTrue(insMedico.InserirMedico(Nome, Especialidade, NIF, Inicio, Fim));
            //Assert.Fail();
        }


        [TestMethod()]
        public void InserirMedicoTest1()
        {

            Inserir_Medico insMedico = new Inserir_Medico();
            insMedico.container = new DiagramaMDSContainer1();

            string Nome = "Ana Malhoa";
            string Especialidade = "Oftalmologia";
            int NIF = 5;
            DateTime Inicio = DateTime.Now;
            DateTime Fim = DateTime.Now.AddHours(5);

            Assert.IsFalse(insMedico.InserirMedico(Nome, Especialidade, NIF, Inicio, Fim));
            //Assert.Fail();
        }


    }
}