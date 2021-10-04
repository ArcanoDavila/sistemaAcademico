using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_model
{
    public class clsCommon
    {

        private string _nome;
        private string _sigla;
        private string _obs;

        public string Nome { get => _nome; set => _nome = value; }
        public string Sigla { get => _sigla; set => _sigla = value; }
        public string Obs { get => _obs; set => _obs = value; }
    }
}
