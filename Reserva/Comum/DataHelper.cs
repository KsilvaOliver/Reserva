using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Configuration;
using System.Data;


namespace Reserva.Comum
{
    public class DataHelper
    {
        public static T ToGenericValue<T>(IDataReader reader, string column)
        {
            var tipoPropriedade = typeof(T);
            var valorDoBd = reader[column];

            return valorDoBd != DBNull.Value ?
                (T)(
                    tipoPropriedade.IsEnum ?
                    Enum.Parse(tipoPropriedade, valorDoBd.ToString()) :
                    valorDoBd
                ) :
                default(T);
        }

        public static Database CreateDatabase()
        {
            return new SqlDatabase(RetornaConnectionString(ConfigurationManager.AppSettings["NameDataBase"]));
        }

        public static string RetornaConnectionString(string db)
        {
            string connectionString = string.Empty;
            if (ConfigurationManager.ConnectionStrings[db] != null)
                connectionString = ConfigurationManager.ConnectionStrings[db].ToString();
            return connectionString;
        }
    }
}
