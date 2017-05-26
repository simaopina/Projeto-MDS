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
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public string Especialidade { get; set; }

        public Medico Medico { get; set; }
        
    }
}
