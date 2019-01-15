using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CarsLibrary
{
   public class CarDriveInfo
    {
        private int _carDriveID = 0;
        private int _driveID = 0;
        private int _carID = 0;
        private string _driveName = "";

        public int CarDriveID
        {
            get
            {
                return _carDriveID;
            }
            set
            {
                _carDriveID = value;
            }
        }
        public int DriveID
        {
            get
            {
                return _driveID;
            }
            set
            {
                _driveID = value;
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

        public string DriveName
        {
            get
            {
                return _driveName;
            }
            set
            {
                _driveName = value;
            }
        }
        public void InsertNewCarDrive()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertCarDrive";

            cm.Parameters.Add(new SqlParameter("@DriveID", _driveID));
            cm.Parameters.Add(new SqlParameter("@CarID", _carID));

            SqlParameter сarDriveID = new SqlParameter();
            сarDriveID.ParameterName = "@CarDriveID";
            сarDriveID.Direction = ParameterDirection.Output;
            сarDriveID.DbType = DbType.Int32;
            cm.Parameters.Add(сarDriveID);

            cm.ExecuteNonQuery();
        }

        public static void DeleteCarDrive(int CarDriveID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = DESKTOP-GJS0S2R ; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteCarDrive";

            cm.Parameters.Add(new SqlParameter("@CarDriveID", CarDriveID));

            cm.ExecuteNonQuery();

        }
    }
}
