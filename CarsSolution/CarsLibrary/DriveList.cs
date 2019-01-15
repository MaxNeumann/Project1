using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CarsLibrary
{
   public class DriveList : List<DriveInfo>
    {
       public static DriveList GetDriveList()
       {
           DriveList myDriveList = new DriveList();

           SqlConnection cn = new SqlConnection();

           cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R; Initial Catalog = CarsDB; Integrated Security = True";
           cn.Open();
           SqlCommand cm = cn.CreateCommand();
           cm.CommandType = CommandType.StoredProcedure;
           cm.CommandText = "GetDriveList";

           SqlDataReader dr = cm.ExecuteReader();
           while (dr.Read())
           {
               DriveInfo newDrive = new DriveInfo();
               newDrive.DriveID = (int)dr["DriveID"];

               newDrive.DriveName = dr["DriveName"].ToString();

               myDriveList.Add(newDrive);
           }

           return myDriveList;

       }
    }
}
