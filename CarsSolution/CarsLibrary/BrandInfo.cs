using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CarsLibrary
{
   public class BrandInfo
    {
        private int _brandID = 0;
        private string _brandName = "";

        public int BrandID
        {
            get
            {
                return _brandID;
            }
            set
            {
                _brandID = value;
            }
        }

        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                _brandName = value;
            }

        }


        public void DeleteBrand()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteBrand";

            cm.Parameters.Add(new SqlParameter("@BrandID", _brandID));

            cm.ExecuteNonQuery();

        }

        public void UpdateBrand()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateBrand";

            cm.Parameters.Add(new SqlParameter("@BrandID", _brandID));
            cm.Parameters.Add(new SqlParameter("@BrandName", _brandName));

        }

        public void GetBrand(int carID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetBrand";

            cm.Parameters.Add(new SqlParameter("@BrandID", _brandID));

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {

                _brandID = (int)dr["BrandID"];
                _brandName = dr["BrandName"].ToString();
            }


        }

        public void InsertNewCar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertBrand";

            cm.Parameters.Add(new SqlParameter("@BrandName", _brandName));

            cm.Parameters.Add(new SqlParameter("@BrandID", _brandID));


            cm.ExecuteNonQuery();
        }
    }
}
