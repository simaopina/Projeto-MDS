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
        public string Especialidade { get; set; }

        //private string _nome;
        private string _especialidade;
        private int _NIF;
        private DateTime _inicio;
        private DateTime _fim;

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


        public Medico(string nome, string especialidade, int _NIF, DateTime _inicio, DateTime _fim)
        {
            Nome = nome;
            Especialidade = especialidade;
            NIF = _NIF;
            Inicio = _inicio;
            Fim = _fim;

        }

        public override string ToString()
        {
            return Inicio.ToString() + Fim.ToString();
        }

    }
    

    }

