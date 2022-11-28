using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_chances
{
    class Conexao_MySql
    {
        public MySqlConnection Conexao()
        {
            return new MySqlConnection("user id=root; password=root; server=localhost; database=tres_chances; SslMode=none");
        }
    }
}
