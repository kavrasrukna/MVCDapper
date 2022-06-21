using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;//ekle
using System.Data;//ekle
using System.Data.SqlClient;//ekle

namespace aspnetmvcdapper.Models
{
    public class DP
    {
        private static string connectionString = @"Server=.; Database=Stoktakibi; Integrated Security=true;";

        public static void ExecuteWithoutReturn(string procadi, DynamicParameters param = null)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                baglanti.Execute(procadi, param, commandType: CommandType.StoredProcedure);
            }
        }
        public static T ExecuteReturnScalar<T>(string procadi, DynamicParameters param = null)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                return (T)Convert.ChangeType(baglanti.ExecuteScalar(procadi, param, commandType: CommandType.StoredProcedure), typeof(T));
                //baglanti.Execute(procadi,param,commandType:CommandType.StoredProcedure);
            }
        }
        public static IEnumerable<T> ReturnList<T>(string procadi, DynamicParameters param = null) //bu t değişkeni her şeyin yerini tutar bir tablo olduğu için t yzadık yoksa tabloların adı olacaktı
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                return baglanti.Query<T>(procadi, param, commandType: CommandType.StoredProcedure);

            }
        }
    }
}