using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class clsPeriodos:clsCommon
    {
        private int _idPeriodo;


        public int PeriodoID
        {
            get { return _idPeriodo; }
            set { _idPeriodo = value; }
        }
    }
}

