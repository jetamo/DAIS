using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer
{
    public class Zapas
    {

        public int? ID { get; set; }
        public int? skore1 { get; set; }
        public int? skore2 { get; set; }
        public Turnaj? turnaj { get; set; }
        public Tym? tym1 { get; set; }
        public Tym? tym2 { get; set; }
        public Tym? tymVitez { get; set; }


        public DataTable FindD()
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Zapasy";
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

                    string sql = "SELECT * FROM Zapasy z WHERE z.z_id = @p_z_id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_z_id", _id);
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
            return "";
        }

        public Zapas(int _id, int _skore1, int _skore2, Turnaj _turnaj, Tym _tym1, Tym _tym2, Tym _tymVitez)
        {
            ID = _id;
            skore1 = _skore1;
            skore2 = _skore2;
            turnaj = _turnaj;
            tym1 = _tym1;
            tym2 = _tym2;
            tymVitez = _tymVitez;

        }
        public Zapas()
        {
            ID = null;
            skore1 = null;
            skore2 = null;
            turnaj = null;
            tym1 = null;
            tym2 = null;
            tymVitez = null;
        }

        public static List<Zapas> Find()
        {
            List<Zapas> zapasList = new List<Zapas>();

            DataTable dt = new Zapas().FindD();
            foreach (DataRow dr in dt.Rows)
                zapasList.Add(MapResultsetToObject(dr));

            return zapasList;
        }

        public static Zapas Find(int _id)
        {
            Zapas zapas = new Zapas();

            DataTable dt = Zapas.FindD(_id);
            zapas = MapResultsetToObject(dt.Rows[0]);

            return zapas;
        }

        public static Zapas MapResultsetToObject(DataRow dr)
        {
            Zapas zapas = new Zapas();
            zapas.ID = Convert.ToInt32(dr.ItemArray[0].ToString());
            zapas.skore1 = Convert.ToInt32(dr.ItemArray[1].ToString());
            zapas.skore2 = Convert.ToInt32(dr.ItemArray[2].ToString());
            zapas.turnaj = Turnaj.MapResultsetToObject(Turnaj.FindD(Convert.ToInt32(dr.ItemArray[3].ToString())).Rows[0]);
            zapas.tym1 =   Tym.MapResultsetToObject(Tym.FindD(Convert.ToInt32(dr.ItemArray[4].ToString())).Rows[0]);
            zapas.tym2 =   Tym.MapResultsetToObject(Tym.FindD(Convert.ToInt32(dr.ItemArray[5].ToString())).Rows[0]);
            zapas.tymVitez =  Tym.MapResultsetToObject(Tym.FindD(Convert.ToInt32(dr.ItemArray[6].ToString())).Rows[0]);

            return zapas;
        }
    }
}
