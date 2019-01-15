using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CarsLibrary
{
    public class CarList : List<CarInfo>
    {
        public static CarList GetDefaultCarList(int brandID, string searchValue)
        {
            CarList myList = new CarList();

            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R; Initial Catalog = CarsDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetCarList";

            cm.Parameters.Add(new SqlParameter("@BrID", brandID));
            cm.Parameters.Add(new SqlParameter("@SearchName", searchValue));

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                CarInfo newCar = new CarInfo();

                newCar.CarName = dr["CarName"].ToString();

                newCar.CarReleaseDate = (DateTime)dr["CarReleaseDate"];

                if (dr["CarReleaseDate"] == (DBNull.Value))
                {
                    newCar.CarReleaseDateString = "";
                }
                else
                {
                    newCar.CarReleaseDate = (DateTime)dr["CarReleaseDate"];
                    newCar.CarReleaseDateString = newCar.CarReleaseDate.ToShortDateString();
                }

                newCar.CarID = (int)dr["CarID"];
                newCar.BrandID = (int)dr["BrandID"];
                newCar.BrandName = dr["BrandName"].ToString();
                newCar.ProducingCountryID = (int)dr["ProducingCountryID"];
                newCar.ProducingCountryName = dr["ProducingCountryName"].ToString();


                myList.Add(newCar);
            }

            return myList;

        }


    }
}
