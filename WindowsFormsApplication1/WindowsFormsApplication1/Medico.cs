using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Medico
    {
        public string Nome { get; set; }


        public string Especialidade;
        public int _NIF;
        public DateTime _inicio;
        public DateTime _fim;

        public int NIF
        {
            get { return _NIF; }
            set
            {
                _NIF = value;
                if (_NIF < 99999999)
                {
                    _NIF = 0;
                }
            }
        }

        public DateTime Inicio
        {
            get { return _inicio; }
            set
            {
                _inicio = value;
            }
        }

        public DateTime Fim
        {
            get { return _fim; }
            set
            {
                _fim = value;
            }
        }

    }
    




    }

