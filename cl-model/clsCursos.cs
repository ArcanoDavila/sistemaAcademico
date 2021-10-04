using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_model
{
    public class clsCursos:clsCommon
    {
        private int _cursoID;
        private int _periodoID; 


        public int CursoID { get => _cursoID; set => _cursoID = value; }
        public int PeriodoID { get => _periodoID; set => _periodoID = value; }

    }
}
