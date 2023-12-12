using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Dal
{
    public class DalClass1
    {

        public DataTable GetBindItmCode()
        {
            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("SpDrpImcd", sc);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetBindItmName()
        {
            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("SpDrpImcd", sc);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //public DataTable GetBindItmCatagory()
        //{
        //    string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
        //    SqlConnection sc = new SqlConnection(str);
        //    SqlCommand cmd = new SqlCommand("SpDrpCatgary", sc);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);

        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

        public DataTable GetBindItmSubCatagory(int CategoryId)
        {
            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("SpSubCatBind", sc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CategoryId", CategoryId);


            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }









        public int SaveData(ModelClass1 model)
        {
            int res = 0;


            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("Save_ItemMaster_28Nov23", sc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ItemCode", model.Itemcode);
            cmd.Parameters.AddWithValue("@ItemName", model.Itemname);
            cmd.Parameters.AddWithValue("@ManufacturerId", model.ManufacturerId);
            cmd.Parameters.AddWithValue("@Material", model.Material);
            cmd.Parameters.AddWithValue("@ItemType", model.Itemtype);
            cmd.Parameters.AddWithValue("@ItemSubType", model.Itemsubtype);
            cmd.Parameters.AddWithValue("@Color", model.Color);
            cmd.Parameters.AddWithValue("@UOMId", model.UOM);
            cmd.Parameters.AddWithValue("@HSNCODE", model.HSNcode);
            cmd.Parameters.AddWithValue("@GSTRate", model.GSTrate);
            cmd.Parameters.AddWithValue("@PurchaseCost", model.Purchaseprice);
            cmd.Parameters.AddWithValue("@SellingPrice", model.Sellingprice);
            



            sc.Open();
            res = cmd.ExecuteNonQuery();
            sc.Close();

            return res;

        }

        //public int Update(ModelClass1 model)
        //{
        //    int res = 0;

        //    string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
        //    SqlConnection sc = new SqlConnection(str);
        //    SqlCommand cmd = new SqlCommand("Update_ItemMaster_28Nov23", sc);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@ItemCode", model.Itemcode);
        //    cmd.Parameters.AddWithValue("@ItemName", model.Itemname);
        //    cmd.Parameters.AddWithValue("@ManufacturerId", model.ManufacturerId);
        //    cmd.Parameters.AddWithValue("@Material", model.Material);
        //    cmd.Parameters.AddWithValue("@ItemType", model.Itemtype);
        //    cmd.Parameters.AddWithValue("@ItemSubType", model.Itemsubtype);
        //    cmd.Parameters.AddWithValue("@Color", model.Color);
        //    cmd.Parameters.AddWithValue("@UOMId", model.UOM);
        //    cmd.Parameters.AddWithValue("@HSNCODE", model.HSNcode);
        //    cmd.Parameters.AddWithValue("@GSTRate", model.GSTrate);
        //    cmd.Parameters.AddWithValue("@PurchaseCost", model.Purchaseprice);
        //    cmd.Parameters.AddWithValue("@SellingPrice", model.Sellingprice);


        //    return res;

        //}

       public DataTable SearchData(string ItemCode)
        {


            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("spSearchItem28Nov23", sc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ItemCode", ItemCode);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

          

            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }


        public int DeleteData(string itemCode)
        {
            int res = 0;


            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("spDeleteItem28Nov23", sc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ItemCode", itemCode);

            sc.Open();
            res = cmd.ExecuteNonQuery();
            sc.Close();

            return res;

        }
    }
}
