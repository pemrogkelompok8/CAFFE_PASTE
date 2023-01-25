using System;
using System.Data.Entity;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace CafeManagement
{
    internal class MySqlConnetion
    {
        private string connection;

        public MySqlConnetion(string connection)
        {
            this.connection = connection;
        }

        public static implicit operator MySqlConnection(MySqlConnetion v)
        {
            return new MySqlConnection(v.connection);
        }
    }
}