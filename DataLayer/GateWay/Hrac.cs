using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer
{
    public class Hrac
    {

        public int? ID { get; set; }
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public DateTime? datumZalozeni { get; set; }
        public string zeme { get; set; }
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

                    string sql = "SELECT * FROM Hraci";
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

                    string sql = "SELECT * FROM Hraci h WHERE h.h_id = @p_h_id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_h_id", _id);
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


        public static int getLastID()
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT MAX(h_id) FROM Hraci";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }

            catch { return -1; }
        }

        public void Pridat()
        {
            this.ID = Hrac.getLastID() + 1;
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Hraci VALUES(@p_id, @p_jmeno, @p_prijmeni, @p_datum, @p_zeme, @p_tym_id)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_id", this.ID);
                        command.Parameters.AddWithValue("@p_jmeno", this.jmeno);
                        command.Parameters.AddWithValue("@p_prijmeni", this.prijmeni);
                        command.Parameters.AddWithValue("@p_datum", this.datumZalozeni);
                        command.Parameters.AddWithValue("@p_zeme", this.zeme);
                        command.Parameters.AddWithValue("@p_tym_id", this.tym.ID);
                        command.ExecuteNonQuery();
                    }
                }
            }

                catch(Exception e) {; }
        }

        public void Upravit()
        {
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "UPDATE Hraci SET jmeno = @p_jmeno, prijmeno = @p_prijmeni, datumZalozeni = @p_datum, zeme = @p_zeme, tym_id = @p_tym_id WHERE h_id = @p_id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_id", this.ID);
                        command.Parameters.AddWithValue("@p_jmeno", this.jmeno);
                        command.Parameters.AddWithValue("@p_prijmeni", this.prijmeni);
                        command.Parameters.AddWithValue("@p_datum", this.datumZalozeni);
                        command.Parameters.AddWithValue("@p_zeme", this.zeme);
                        command.Parameters.AddWithValue("@p_tym_id", this.tym.ID);
                        command.ExecuteNonQuery();
                    }
                }
            }

            catch(Exception e) {
                ; }
        }


        public void Smazat()
        {
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Hraci WHERE h_id = @p_id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_id", this.ID);
                        command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception e)
            {
                ;
            }
        }


        public override string ToString()
        {
            return this.jmeno + " " + this.prijmeni;
        }

        public Hrac(int _id, string _jmeno, string _prijmeni, DateTime _datumZalozeni, string _zeme, Tym _tym)
        {
            ID = _id;
            jmeno = _jmeno;
            prijmeni = _prijmeni;
            datumZalozeni = _datumZalozeni;
            zeme = _zeme;
            tym = _tym;
        }
        public Hrac()
        {
            ID = null;
            jmeno = null;
            prijmeni = null;
            datumZalozeni = null;
            zeme = null;
            tym = null;
        }

        public static List<Hrac> Find()
        {
            List<Hrac> hracList = new List<Hrac>();

            DataTable dt = new Hrac().FindD();
            foreach (DataRow dr in dt.Rows)
                hracList.Add(MapResultsetToObject(dr));

            return hracList;
        }

        public static Hrac Find(int _id)
        {
            Hrac hrac = new Hrac();

            DataTable dt = new Hrac().FindD(_id);
            hrac = MapResultsetToObject(dt.Rows[0]);

            return hrac;
        }

        public static Hrac MapResultsetToObject(DataRow dr)
        {
            Hrac hrac = new Hrac();
            hrac.ID = Convert.ToInt32(dr.ItemArray[0].ToString());
            hrac.jmeno = dr.ItemArray[1].ToString();
            hrac.prijmeni = dr.ItemArray[2].ToString();
            hrac.datumZalozeni = Convert.ToDateTime(dr.ItemArray[3].ToString());
            hrac.zeme = dr.ItemArray[4].ToString();
            hrac.tym = Tym.MapResultsetToObject(Tym.FindD(Convert.ToInt32(dr.ItemArray[5].ToString())).Rows[0]);

            return hrac;
        }
    }
}
