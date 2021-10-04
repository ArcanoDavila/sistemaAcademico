using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_model
{
    public class clsDisciplinaCurso
    {
        private int _idCurso;
        private int _idDisciplina;

        public int IdCurso { get => _idCurso; set => _idCurso = value; }
        public int IdDisciplina { get => _idDisciplina; set => _idDisciplina = value; }
    }
}
