using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CarsLibrary
{
   public class BrandList : List<BrandInfo>
    {
       public static BrandList GetBrandList()
       {
           BrandList brList = new BrandList();

           SqlConnection cn = new SqlConnection();


           cn.ConnectionString = "Data Source = DESKTOP-GJS0S2R; Initial Catalog = CarsDB; Integrated Security = True";
           cn.Open();

           SqlCommand cm = cn.CreateCommand();
           cm.CommandType = CommandType.StoredProcedure;
           cm.CommandText = "GetBrandList";

           SqlDataReader dr = cm.ExecuteReader();
           while (dr.Read())
           {
               BrandInfo newBrand = new BrandInfo();


               newBrand.BrandID = (int)dr["BrandID"];
               newBrand.BrandName = dr["BrandName"].ToString();

               brList.Add(newBrand);
           }

           return brList;

       }
    }
}
