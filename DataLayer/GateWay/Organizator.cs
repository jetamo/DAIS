using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer
{
    public class Organizator
    {

        public int? ID { get; set; }
        public string nazev { get; set; }
        public string zeme { get; set; }
        public int? pocetZamestnancu { get; set; }
        public DateTime? zalozeno { get; set; }


        public DataTable FindD()
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Organizatori";
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

                    string sql = "SELECT * FROM Organizatori o WHERE o.org_id = @p_org_id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_org_id", _id);
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

        public Organizator(int _id, string _nazev, string _zeme, int? _pocetZamestnancu, DateTime? _zalozeno)
        {
            ID = _id;
            nazev = _nazev;
            zeme = _zeme;
            pocetZamestnancu = _pocetZamestnancu;
            zalozeno = _zalozeno;
        }
        public Organizator()
        {
            ID = null;
            nazev = null;
            zeme = null;
            pocetZamestnancu = null;
            zalozeno = null;
        }

        public static List<Organizator> Find()
        {
            List<Organizator> organizatorList = new List<Organizator>();

            DataTable dt = new Organizator().FindD();
            foreach (DataRow dr in dt.Rows)
                organizatorList.Add(MapResultsetToObject(dr));

            return organizatorList;
        }

        public static Organizator Find(int _id)
        {
            Organizator organizator = new Organizator();

            DataTable dt = Organizator.FindD(_id);
            organizator = MapResultsetToObject(dt.Rows[0]);

            return organizator;
        }

        public static Organizator MapResultsetToObject(DataRow dr)
        {
            Organizator organizator = new Organizator();
            organizator.ID = Convert.ToInt32(dr.ItemArray[0].ToString());
            organizator.nazev = dr.ItemArray[1].ToString();
            organizator.zeme = dr.ItemArray[2].ToString();
            organizator.pocetZamestnancu = Convert.ToInt32(dr.ItemArray[3].ToString());
            organizator.zalozeno = Convert.ToDateTime(dr.ItemArray[4].ToString());

            return organizator;
        }
    }
}
