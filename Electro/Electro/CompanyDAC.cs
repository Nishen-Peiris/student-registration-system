using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Electro
{
    public sealed class CompanyDAC
    {
        public static SqlDataReader Getcompanyinformation1_1()
        {
            //TODO:Add constructor logic here

            SqlDataReader reader1_1;
            string sql = "Select * from Table1 order by Fullname";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                reader1_1 = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
            }
            return reader1_1;
        }

        public static SqlDataReader Getcompanyinformation1_2()
        {
            //TODO:Add constructor logic here

            SqlDataReader reader1_2;
            string sql = "Select * from Table1 order by Fullname desc";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                reader1_2 = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
            }
            return reader1_2;
        }

        public static SqlDataReader Getcompanyinformation2_1()
        {
            //TODO:Add constructor logic here

            SqlDataReader reader2_1;
            string sql = "Select * from Table1 order by DOB";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                reader2_1 = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
            }
            return reader2_1;
        }

        public static SqlDataReader Getcompanyinformation2_2()
        {
            //TODO:Add constructor logic here

            SqlDataReader reader2_2;
            string sql = "Select * from Table1 order by DOB desc";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                reader2_2 = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
            }
            return reader2_2;
        }

        public static SqlDataReader Getcompanyinformation3_1()
        {
            //TODO:Add constructor logic here

            SqlDataReader reader3_1;
            string sql = "Select * from Table1 order by DOR";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                reader3_1 = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
            }
            return reader3_1;
        }

        public static SqlDataReader Getcompanyinformation3_2()
        {
            //TODO:Add constructor logic here

            SqlDataReader reader3_2;
            string sql = "Select * from Table1 order by DOR desc";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                reader3_2 = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
            }
            return reader3_2;
        }
    }
}
