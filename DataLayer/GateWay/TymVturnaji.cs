using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer
{
    public class TymVturnaji
    {

        public Tym? tym { get; set; }
        public Turnaj? turnaj { get; set; }


        public DataTable FindD()
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM TymyVturnaji";
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


        public override string ToString()
        {
            return "";
        }

        public TymVturnaji(Tym _tym, Turnaj _turnaj)
        {
            tym = _tym;
            turnaj = _turnaj;
        }
        public TymVturnaji()
        {
            tym = null;
            turnaj = null;
        }

        public static List<TymVturnaji> Find()
        {
            List<TymVturnaji> tvtList = new List<TymVturnaji>();

            DataTable dt = new TymVturnaji().FindD();
            foreach (DataRow dr in dt.Rows)
                tvtList.Add(MapResultsetToObject(dr));

            return tvtList;
        }


        public static TymVturnaji MapResultsetToObject(DataRow dr)
        {
            TymVturnaji tvt = new TymVturnaji();
            tvt.tym =    Tym.MapResultsetToObject(Tym.FindD(Convert.ToInt32(dr.ItemArray[0].ToString())).Rows[0]);
            tvt.turnaj = Turnaj.MapResultsetToObject(Turnaj.FindD(Convert.ToInt32(dr.ItemArray[1].ToString())).Rows[0]);

            return tvt;
        }


        public static string PrihlasitDoTurnaje(int _id_turnaje)
        {
            SqlConnectionStringBuilder builder = DBconnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("PrihlasitDoTurnaje", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_trener_id", Global.IdTrener);
                    cmd.Parameters.AddWithValue("@p_turnaj_id", _id_turnaje);
                    var error = cmd.Parameters.Add("@o_error", SqlDbType.Bit);
                    var error_msg = cmd.Parameters.Add("@o_error_msg", SqlDbType.VarChar, 50);
                    error.Direction = ParameterDirection.Output;
                    error_msg.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    if (Convert.ToBoolean(error.Value))
                    {
                        return(error_msg.Value.ToString());
                    }
                }
                return null;
            }
            catch(Exception e) {
                return e.Message;
            }
        }
    }
}
