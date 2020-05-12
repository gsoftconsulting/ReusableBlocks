using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Sql
{
    public class SqlListReaderBlock<T> : IListReader<T> where T : class
    {
        private SqlCommand command;
        private String sql;
        private SqlConnection connection;
        private List<SqlParameter> parameters;

        public SqlListReaderBlock(String sql, SqlConnection c)
        {
           this.sql = sql;
           this.connection = c;
        }

        public SqlListReaderBlock(SqlCommand cmd)
        {
            command = cmd;
        }

        public SqlListReaderBlock(String sql, SqlConnection c, List<SqlParameter> p)
        {
            this.sql = sql;
            this.connection = c;
            this.parameters = p;            
        }

        public IList<T> Read()
        {
            if (command != null)
            {
                return Read(command);
            }

            return ReadFromSql();
        }

        private List<T> Read(SqlCommand cmd)
        {            
            if (cmd.Connection.State != System.Data.ConnectionState.Open)
                cmd.Connection.Open();            

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                List<T> list = new List<T>();
                SqlReaderBlock<T> readerBlock = new SqlReaderBlock<T>(reader);

                T t = readerBlock.Read();
                while (t != null)
                {
                    list.Add(t);
                    t = readerBlock.Read();
                }

                return list;
            }
            
        }

        private List<T> ReadFromSql()
        {
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    parameters.ForEach((x) => cmd.Parameters.Add(x));
                }

                return Read(cmd);
            }
        }

    }
}
