using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CarsLibrary
{
    public class CarDriveList : List<CarDriveInfo>
    {
        public static CarDriveList GetCarDrive(int CarID)
        {
            CarDriveList myList = new CarDriveList();

            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetCarDrive";
            cm.Parameters.Add(new SqlParameter("@CarID", CarID));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                CarDriveInfo newDrive = new CarDriveInfo();

                newDrive.DriveName = dr["DriveName"].ToString();
                newDrive.DriveID = (int)dr["DriveID"];
                newDrive.CarID = (int)dr["CarID"];
                newDrive.CarDriveID = (int)dr["CarDriveID"];

                myList.Add(newDrive);
            }

            return myList;

        }
    }
}
