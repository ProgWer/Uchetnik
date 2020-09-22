using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Uchetnik
{
    class SQL
    {
        MySqlCommand cmd;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable table = new DataTable();

        public bool AuthQuery(string parametr)
        {
            bool res = false; string command= "select * from authentication where id = '" + parametr + "';";
            if (Query(command).Rows.Count == 1) res = true;
            return res;
        }
        private DataTable Query(string SQLCommand)
        {
            cmd = new MySqlCommand(SQLCommand, server.getConnection());
            adapter.SelectCommand = cmd; adapter.Fill(table);
            return table;
        }
    }
}
