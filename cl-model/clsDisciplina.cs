using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace Domain
{
    public class clsDisciplina
    {
        private DisciplinaDao objetoDisciplina = new DisciplinaDao();

        public DataTable MostrarDisciplina()
        {
            DataTable _table = new DataTable();
            _table = objetoDisciplina.MostrarDisciplina();
            return _table;
        }

        public void InsertDisciplina(string nome, string sigla,string obs, string ID, string idcur)
        {
            objetoDisciplina.InsertDisciplina(nome, sigla, obs,Convert.ToInt32(idcur), Convert.ToInt32(ID));
        }

        public void EditarDisciplina(string nome, string sigla, string obs, string ID, string idcur)
        {
            objetoDisciplina.EditarDisciplina(nome, sigla, obs, Convert.ToInt32(idcur), Convert.ToInt32(ID));
        }

        public void DeleteDisciplina(string ID)
        {
            objetoDisciplina.DeleteDisciplina(Convert.ToInt32(ID));
        }
    }
}
