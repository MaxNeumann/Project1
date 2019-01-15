using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CarsLibrary
{
    public class ProducingCountryInfo
    {
        private int _producingCountryID = 0;
        private string  _producingCountryName = "";
    
        public int ProducingCountryID
        {
            get
            {
                return _producingCountryID;
            }
            set
            {
                _producingCountryID = value;
            }
        }

        public string ProducingCountryName
        {
            get
            {
                return _producingCountryName;
            }
            set
            {
                _producingCountryName = value;
            }
        }

        public void DeleteProducingCountry()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteProducingCountry";

            cm.Parameters.Add(new SqlParameter("@ProducingCountryID", _producingCountryID));

            cm.ExecuteNonQuery();
        }

        public void GetProducingCountry(int personID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R; Initial Catalog = CarsDB; Integrated Security = True";

            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetProducingCountry";

            cm.Parameters.Add(new SqlParameter("@ProducingCountryID", _producingCountryID));

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {

                _producingCountryID = (int)dr["ProducingCountryID"];
                _producingCountryName = dr["ProducingCountryName"].ToString();
            };
        }

        public void InsertProducingCountry()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertProducingCountry";

            cm.Parameters.Add(new SqlParameter("@ProducingCountryName", _producingCountryName));

            cm.Parameters.Add(new SqlParameter("@ProducingCountryID", _producingCountryID));


            cm.ExecuteNonQuery();
        }

        public void UpdateProducingCountry()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateProducingCountry";

            cm.Parameters.Add(new SqlParameter("@ProducingCountryID", _producingCountryID));
            cm.Parameters.Add(new SqlParameter("@ProducingCountryName", _producingCountryName));
        }
    }
    }

