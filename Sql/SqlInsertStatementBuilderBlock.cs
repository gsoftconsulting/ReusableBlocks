using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Sql
{
    public class SqlInsertStatementBuilderBlock 
    {
        public String Build(String tableName, IList<SqlParameter> parameters)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("INSERT INTO {0} {", tableName);

            Boolean isFirst = true;
            foreach (var p in parameters)
            {
                if (isFirst)
                {
                    sb.Append(p.ParameterName);
                    isFirst = false;
                }
                else
                {
                    sb.Append(", ");
                    sb.Append(p.ParameterName);
                }
            }

            sb.Append("VALUES (");
            isFirst = true;
            foreach (var p in parameters)
            {
                if (isFirst)
                {
                    sb.Append("@");
                    sb.Append(p.ParameterName);
                    isFirst = false;
                }
                else
                {
                    sb.Append(", @");
                    sb.Append(p.ParameterName);
                }
            }

            return sb.ToString();
        }

    //        Public Function BuildInsertStatement(table As String, parameters As IEnumerable(Of SqlParameter)) As String
    //    Dim s As New System.Text.StringBuilder("INSERT INTO ")
    //    s.Append(table)
    //    s.Append(" (")

                    //    For Each p In parameters
                    //        s.AppendFormat("{0}, ", p.ParameterName)
                    //    Next
                    //    s(s.Length - 2) = ")"c
                    //    s.Append("VALUES (")

                    //    For Each p In parameters
                    //        s.AppendFormat("@{0}, ", p.ParameterName)
                    //    Next
                    //    s(s.Length - 2) = ")"c

                    //    Return s.ToString()
                    //End Function

            //}

    }
}
