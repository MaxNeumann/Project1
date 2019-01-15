using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CarsLibrary
{
    public class CarInfo
    {
        private int _carID = 0;
        private string _carName ="";
        private DateTime _carReleaseDate= DateTime.Today;
        private int _brandID = 0;
        private string _brandName = "";
        private int _producingCountryID = 0;
        private string _producingCountryName = "";
        private string _carReleaseDateString = "";


        public string CarReleaseDateString
        {
            get
            {
                return _carReleaseDateString;
            }
            set
            {
                _carReleaseDateString = value;
            }
        }
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


        public string CarName
        {
            get
            {
                return _carName;
            }
            set
            {
                _carName = value;
            }
        }

        public DateTime CarReleaseDate
        {
            get
            {
                return _carReleaseDate;
            }
            set
            {
                _carReleaseDate = value;
            }
        }

        public int CarAge
        {
            get
            {
                return DateTime.Today.Year - _carReleaseDate.Year;
            }
            
        }

        public int CarID
        {
            get
            {
                return _carID;
            }
            set
            {
                _carID = value;
            }
        }
    
        public void InsertCar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";

            cn.Open();

            SqlTransaction sqlTran = cn.BeginTransaction();

            SqlCommand cm = cn.CreateCommand();
            cm.Transaction = sqlTran;

            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "InsertCar";

                cm.Parameters.Add(new SqlParameter("@CarName", _carName));
                cm.Parameters.Add(new SqlParameter("@CarReleaseDate", _carReleaseDate));
                cm.Parameters.Add(new SqlParameter("@BrandID", _brandID));
                cm.Parameters.Add(new SqlParameter("@ProducingCountryID", _producingCountryID));

                SqlParameter сarID = new SqlParameter();
                сarID.ParameterName = "@CarID";
                сarID.Direction = ParameterDirection.Output;
                сarID.DbType = DbType.Int32;
                cm.Parameters.Add(сarID);



                cm.ExecuteNonQuery();
                _carID = (int)сarID.Value;

                cm.CommandText = "InsertTest1";

                cm.ExecuteNonQuery();

                sqlTran.Commit();
            }
            catch
            {
                sqlTran.Rollback();
            }

           
            
        }
        public void DeleteCar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteCar";

            cm.Parameters.Add(new SqlParameter("@CarID", _carID));
            
            cm.ExecuteNonQuery();
        
        }

        public void UpdateCar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateCar";

            cm.Parameters.Add(new SqlParameter("@CarID", _carID));
            cm.Parameters.Add(new SqlParameter("@CarName", _carName));
            cm.Parameters.Add(new SqlParameter("@CarReleaseDate", _carReleaseDate));
            cm.Parameters.Add(new SqlParameter("@BrandID", _brandID));
            cm.Parameters.Add(new SqlParameter("@ProducingCountryID", _producingCountryID));

            cm.ExecuteNonQuery();
        
        }

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

        public void GetCar(int carID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetCar";

            cm.Parameters.Add(new SqlParameter("@CarID", carID));

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                _carName = dr["CarName"].ToString();
                _carReleaseDate = (DateTime)dr["CarReleaseDate"];
                _carID = (int)dr["CarID"];
                _brandID = (int)dr["BrandID"];
                _brandName = dr["BrandName"].ToString();
                _producingCountryID = (int)dr["ProducingCountryID"];
                _producingCountryName = dr["ProducingCountryName"].ToString();
              
            }


        }


    }
}
