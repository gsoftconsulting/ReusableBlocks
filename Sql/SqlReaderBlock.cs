using ReusableBlocks.Interfaces;
using ReusableBlocks.Writers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Sql
{
    public class SqlReaderBlock<T> : IReader<T> where T : class
    {
        private SqlDataReader reader;        
        private String sql;
        private SqlConnection connection;
        private List<SqlParameter> parameters;

        public SqlReaderBlock(SqlDataReader r)
        {
            reader = r;
        }

        public SqlReaderBlock(String sql, SqlConnection c)
        {
            this.sql = sql;
            connection = c;
        }

        public SqlReaderBlock(String sql, SqlConnection c, List<SqlParameter> p)
        {
            this.sql = sql;
            connection = c;
            parameters = p;
        }

        public T Read()
        {
            if (reader != null)
            {
                if (reader.HasRows && reader.Read())
                    return ReadItem();
            }
            else
            {
                using(SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    if (connection.State != ConnectionState.Open) 
                    {
                        connection.Open();
                    }

                    if (parameters != null) 
                    {
                        parameters.ForEach((x) => cmd.Parameters.Add(x));
                    }

                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                            return ReadItem();
                    }
                }
            }

            return null;
        }

        private T ReadItem()
        {
            T item = Activator.CreateInstance<T>();
            PropertyWriter<T> writer = new PropertyWriter<T>(item);

            for (int i = 0; i < reader.FieldCount; i++)
            {
                String columnName = reader.GetName(i);
                Type columnType = reader.GetFieldType(i);
                object value = reader.GetValue(i);
                writer.Write(columnName, columnType, value);
            }

            return item;
        }
    }
}
