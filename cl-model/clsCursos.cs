using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace Domain
{
    public class clsCursos
    {
        private CursoDao objetoPeriodo = new CursoDao();

        public DataTable MostrarCurso()
        {
            DataTable _table = new DataTable();
            _table = objetoPeriodo.MostrarCurso();
            return _table;
        }

        public void InsertCurso(string nome, string sigla, string obs ,string ID, string idPer)
        {
            objetoPeriodo.InsertCurso(nome, sigla,  Convert.ToInt32(ID), obs, Convert.ToInt32(idPer));
        }

        public void EditarCurso(string nome, string sigla, string obs, string ID, string idPer)
        {
            objetoPeriodo.EditarCurso(nome, sigla, Convert.ToInt32(ID), obs, Convert.ToInt32(idPer));
        }

        public void DeleteCurso(string ID)
        {
            objetoPeriodo.DeleteCurso(Convert.ToInt32(ID));
        }

    }
}
