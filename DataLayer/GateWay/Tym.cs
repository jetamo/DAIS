using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer
{
    public class Tym
    {

        public int? ID { get; set; }
        public string nazev { get; set; }
        public DateTime? zalozeno { get; set; }
        public int? body { get; set; }


        public static DataTable FindD()
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Tymy";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }

            catch { }
            return dt;
        }

        public static DataTable FindD(int _id)
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Tymy t WHERE t.tym_id = @p_tym_id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_tym_id", _id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }

            catch { }
            return dt;
        }


        public static DataTable FindByCoachD(int _id)
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Tymy t JOIN treneri tr on tr.ty_id = t.tym_id WHERE tr.ty_id = @p_tr_id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_tr_id", _id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }

            catch { }
            return dt;
        }

        public override string ToString()
        {
            return this.nazev;
        }

        public Tym(int _id, string _nazev, DateTime _zalozeno, int _body)
        {
            ID = _id;
            nazev = _nazev;
            zalozeno = _zalozeno;
            body = _body;
        }
        public Tym()
        {
            ID = null;
            nazev = null;
            zalozeno = null;
            body = null;
        }

        public static List<Tym> Find()
        {
            List<Tym> tymList = new List<Tym>();

            DataTable dt = Tym.FindD();
            foreach (DataRow dr in dt.Rows)
                tymList.Add(MapResultsetToObject(dr));

            return tymList;
        }

        public static Tym Find(int _id)
        {
            Tym tym = new Tym();

            DataTable dt = Tym.FindD(_id);
            tym = MapResultsetToObject(dt.Rows[0]);

            return tym;
        }
        
        public static Tym FindByCoach(int _id)
        {
            Tym tym = new Tym();

            DataTable dt = Tym.FindByCoachD(_id);
            tym = MapResultsetToObject(dt.Rows[0]);

            return tym;
        }

        public static Tym MapResultsetToObject(DataRow dr)
        {
            Tym tym = new Tym();
            tym.ID = Convert.ToInt32(dr.ItemArray[0].ToString());
            tym.nazev = dr.ItemArray[1].ToString();
            tym.zalozeno = Convert.ToDateTime(dr.ItemArray[2].ToString());
            tym.body = Convert.ToInt32(dr.ItemArray[3].ToString());

            return tym;
        }





        public static string getTymSnejviceBody()
        {
            try
            {
                SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
                string tym;
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("getTymSnejviceBody", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        var returnTym = command.Parameters.Add("@tym", SqlDbType.VarChar, 20);
                        returnTym.Direction = ParameterDirection.Output;
                        command.ExecuteNonQuery();
                        tym = returnTym.Value.ToString();
                    }
                }
                return tym;
            }
            catch(Exception e)
            {
                return "chyba";
            }
        }
    }
}
