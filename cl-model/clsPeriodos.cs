using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using MySql.Data.MySqlClient;


namespace Domain
{
    public class clsPeriodos:clsCommon
    {
        private PeriodoDao objetoPeriodo = new PeriodoDao();

        public DataTable MostrarPeriodos()
        {
            DataTable _table = new DataTable();
            _table = objetoPeriodo.MostrarPeriodo();
            return _table;
        }

        public void InsertPeriodo(string nome, string sigla, string ID)
        {
            objetoPeriodo.InsertPeriodo(nome, sigla, Convert.ToInt32(ID));
        }
        
        public void EditarPeriodo(string nome, string sigla, string ID)
        {
            objetoPeriodo.EditarPeriodo(nome, sigla, Convert.ToInt32(ID));
        }

        public void DeletePeriodo(string ID)
        {
            objetoPeriodo.DeletePeriodo(Convert.ToInt32(ID));
        }
    }
}

