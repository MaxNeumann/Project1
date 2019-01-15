using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CarsLibrary
{
   public class ProducingCountryList : List<ProducingCountryInfo>
    {
       public static ProducingCountryList GetProducingCountryList()
       {
           ProducingCountryList prodList = new ProducingCountryList();

           SqlConnection cn = new SqlConnection();


           cn.ConnectionString = "Data Source =DESKTOP-GJS0S2R; Initial Catalog = CarsDB; Integrated Security = True";
           cn.Open();

           SqlCommand cm = cn.CreateCommand();
           cm.CommandType = CommandType.StoredProcedure;
           cm.CommandText = "GetProducingCountryList";

           SqlDataReader dr = cm.ExecuteReader();
           while (dr.Read())
           {
               ProducingCountryInfo newProducingCountry = new ProducingCountryInfo();


               newProducingCountry.ProducingCountryID = (int)dr["ProducingCountryID"];
               newProducingCountry.ProducingCountryName = dr["ProducingCountryName"].ToString();

               prodList.Add(newProducingCountry);
           }

           return prodList;
       }
    }
}
