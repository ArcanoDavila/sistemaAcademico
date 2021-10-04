using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_model
{
    public class clsDisciplina:clsCommon
    {
        private int _disciplinaID;

        public int DisciplinaID { get => _disciplinaID; set => _disciplinaID = value; }
    }
}
