using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer
{
    public class Turnaj
    {

        public int? ID { get; set; }
        public string nazev { get; set; }
        public DateTime? datumOD { get; set; }
        public DateTime? datumDO { get; set; }
        public int? prizepool { get; set; }
        public string misto { get; set; }
        public string zeme { get; set; }
        public Organizator organizator { get; set; }

        public override string ToString()
        {
            return this.nazev;
        }

        public DataTable FindD()
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Turnaje";
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

                    string sql = "SELECT * FROM Turnaje t WHERE t.tur_id = @p_tur_id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_tur_id", _id);
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

        public static void PripsatBody()
        {
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("PripsatBody", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
            }


        }


        public Turnaj(int _id, string _nazev, DateTime _datumOD, DateTime _datumDO, int _prizepool, string _misto, string _zeme, Organizator _organizator)
        {
            ID = _id;
            nazev = _nazev;
            datumOD = _datumOD;
            datumDO = _datumDO;
            prizepool = _prizepool;
            misto = _misto;
            zeme = _zeme;
            organizator = _organizator;
        }
        public Turnaj()
        {
            ID = null;
            nazev = null;
            datumOD = null;
            datumDO = null;
            prizepool = null;
            misto = null;
            zeme = null;
            organizator = null;
        }

        public static List< Turnaj> Find()
        {
            List<Turnaj> turnajList = new List<Turnaj>();

            DataTable dt = new Turnaj().FindD();
            foreach (DataRow dr in dt.Rows)
                turnajList.Add(MapResultsetToObject(dr));

            return turnajList;
        }

        public static Turnaj Find(int _id)
        {
            Turnaj turnaj = new Turnaj();

            DataTable dt = Turnaj.FindD(_id);
            turnaj = MapResultsetToObject(dt.Rows[0]);

            return turnaj;
        }

        public static Turnaj MapResultsetToObject(DataRow dr)
        {
            Turnaj turnaj = new Turnaj();
            turnaj.ID = Convert.ToInt32(dr.ItemArray[0].ToString());
            turnaj.nazev = dr.ItemArray[1].ToString();
            turnaj.datumOD = Convert.ToDateTime(dr.ItemArray[2].ToString());
            turnaj.datumDO = Convert.ToDateTime(dr.ItemArray[3].ToString());
            turnaj.prizepool = Convert.ToInt32(dr.ItemArray[4].ToString());
            turnaj.misto = dr.ItemArray[5].ToString();
            turnaj.zeme = dr.ItemArray[6].ToString();
            turnaj.organizator = Organizator.MapResultsetToObject(Organizator.FindD(Convert.ToInt32(dr.ItemArray[7].ToString())).Rows[0]);

            return turnaj;
        }
    }
}
