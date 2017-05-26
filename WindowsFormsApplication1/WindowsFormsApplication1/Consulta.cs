using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Consulta
    {
        public string Nome_Paciente { get; set; }
        public string Dia { get; set; }
        public DateTime Hora { get; set; }
        public string Especialidade { get; set; }

        public Medico Medico { get; set; }



        public Consulta(string nome_paciente, string dia, DateTime hora, string especialidade, Medico medico)
        {
            Nome_Paciente = nome_paciente;
            Dia = dia;
            Hora = hora;
            Especialidade = especialidade;
            Medico = medico;
        }

        public Consulta(string nome_paciente, string dia, DateTime hora, string especialidade)
            : this(nome_paciente, dia, hora, especialidade, null) { }

        public override string ToString()
        {
            return Nome_Paciente.ToString() + Dia.Substring(3, 2) + Hora.ToString() + Especialidade.ToString();          
        }
        
    }
}
