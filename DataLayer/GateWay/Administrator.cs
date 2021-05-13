using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer
{
    public class Administrator
    {

        public int? ID { get; set; }
        public string jmeno { get; set; }
        public string prijmeni { get; set; }


        public DataTable FindD()
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Administrator";
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

                    string sql = "SELECT * FROM Administrator a WHERE a.ad_id = @p_ad_id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@p_ad_id", _id);
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
            return this.jmeno + " " + this.prijmeni;
        }

        public Administrator(int _id, string _jmeno, string _prijmeni)
        {
            ID = _id;
            jmeno = _jmeno;
            prijmeni = _prijmeni;
        }
        public Administrator()
        {
            ID = null;
            jmeno = null;
            prijmeni = null;
        }

        public static List<Administrator> Find()
        {
            List<Administrator> administratorList = new List<Administrator>();

            DataTable dt = new Administrator().FindD();
            foreach (DataRow dr in dt.Rows)
                administratorList.Add(MapResultsetToObject(dr));

            return administratorList;
        }

        public static Administrator Find(int _id)
        {
            Administrator admin = new Administrator();

            DataTable dt = new Administrator().FindD(_id);
            admin = MapResultsetToObject(dt.Rows[0]);

            return admin;
        }

        public static Administrator MapResultsetToObject(DataRow dr)
        {
            Administrator admin = new Administrator();
            admin.ID = Convert.ToInt32(dr.ItemArray[0].ToString());
            admin.jmeno = dr.ItemArray[1].ToString();
            admin.prijmeni = dr.ItemArray[2].ToString();

            return admin;
        }
    }
}
