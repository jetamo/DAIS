using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer
{
    public class Trener
    {

        public int? ID { get; set; }
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public Tym? tym { get; set; }


        public DataTable FindD()
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Treneri";
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

        public DataTable FindD(int _id)
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Treneri t WHERE t.tre_id = @p_tre_id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_tre_id", _id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }

            catch(Exception e) {; }
            return dt;
        }

        public override string ToString()
        {
            return this.jmeno + " " + this.prijmeni;
        }

        public Trener(int _id, string _jmeno, string _prijmeni, Tym? _tym)
        {
            ID = _id;
            jmeno = _jmeno;
            prijmeni = _prijmeni;
            tym = _tym;
        }
        public Trener()
        {
            ID = null;
            jmeno = null;
            prijmeni = null;
            tym = null;
        }

        public static List<Trener> Find()
        {
            List<Trener> trenerList = new List<Trener>();

            DataTable dt = new Trener().FindD();
            foreach (DataRow dr in dt.Rows)
                trenerList.Add(MapResultsetToObject(dr));

            return trenerList;
        }

        public static Trener Find(int _id)
        {
            Trener trener = new Trener();

            DataTable dt = new Trener().FindD(_id);
            trener = MapResultsetToObject(dt.Rows[0]);

            return trener;
        }

        public static Trener MapResultsetToObject(DataRow dr)
        {
            Trener trener = new Trener();
            trener.ID = Convert.ToInt32(dr.ItemArray[0].ToString());
            trener.jmeno = dr.ItemArray[1].ToString();
            trener.prijmeni = dr.ItemArray[2].ToString();
            trener.tym = Tym.MapResultsetToObject(Tym.FindD(Convert.ToInt32(dr.ItemArray[3].ToString())).Rows[0]);

            return trener;
        }
    }
}
