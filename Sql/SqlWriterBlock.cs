using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Sql
{
    public class SqlWriterBlock<T> : IWriter<T> 
        where T : class
    {
        private String sql;        
        private SqlConnection connection;
        private List<SqlParameter> parameters;

        
        public SqlWriterBlock(String sql, SqlConnection c)
        {
            this.sql = sql;
            connection = c;
        }

        public SqlWriterBlock(String sql, SqlConnection c, List<SqlParameter> p)
        {
            this.sql = sql;
            connection = c;
            parameters = p;
        }

        public void Write(T item)
        {
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                if (parameters != null)
                {
                    parameters.ForEach((x) => cmd.Parameters.Add(x));
                }

                cmd.ExecuteNonQuery();
            }
        }
    }
}
