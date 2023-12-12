using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Bal;

namespace ItemMasterProject
{
    public partial class ItemMasterWeb : System.Web.UI.Page
    {
        ModelClass1 model = new ModelClass1();
        BalClass1 bal = new BalClass1();


        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                BindItmCode();
                BindItmName();
                //BindItmCatagory();
                //BindItmSubCatagory();
            }

            if (!IsPostBack)
            {

                drpItemSubCat.Enabled = false;

                string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
                SqlConnection sc = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("select * from CategoryMaster ", sc);
                cmd.CommandType = CommandType.Text;



                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                
                drpItemCat.DataSource = dt;
                drpItemCat.DataTextField = "CategoryName";
                drpItemCat.DataValueField = "CategoryId";
                drpItemCat.DataBind();
                drpItemCat.Items.Insert(0, "Select");
            }


        }

        private void BindItmCode()
        {
            DataTable dt = new DataTable();
            dt = bal.GetBindItmCode();

            // Assuming you have a DropDownList called ddlYourDropdown in your ASP.NET markup
            DrpItemCode.DataSource = dt;
            DrpItemCode.DataTextField = "ItemCode";
            DrpItemCode.DataValueField = "ID";
            DrpItemCode.DataBind();
            DrpItemCode.Items.Insert(0, "Select");
        }

        private void BindItmName()
        {
            DataTable dt = new DataTable();
            dt = bal.GetBindItmName();

            // Assuming you have a DropDownList called ddlYourDropdown in your ASP.NET markup
            DrpItemNamw.DataSource = dt;
            DrpItemNamw.DataTextField = "ItemName";
            DrpItemNamw.DataValueField = "ID";
            DrpItemNamw.DataBind();
            DrpItemNamw.Items.Insert(0, "Select");
        }

        //private void BindItmCatagory()
        //{
        //    DataTable dt = new DataTable();
        //    dt = bal.GetBindItmCatagory();

        //    // Assuming you have a DropDownList called ddlYourDropdown in your ASP.NET markup
        //    drpItemCat.DataSource = dt;
        //    drpItemCat.DataTextField = "CategoryName";
        //    drpItemCat.DataValueField = "CategoryName";
        //    drpItemCat.DataBind();
        //    drpItemCat.Items.Insert(0, "Select");

        //}

        //private void BindItmSubCatagory()
        //{
        //    DataTable dt = new DataTable();
        //    dt = bal.GetBindItmSubCatagory();

        //    // Assuming you have a DropDownList called ddlYourDropdown in your ASP.NET markup
        //    drpItemSubCat.DataSource = dt;
        //    drpItemSubCat.DataTextField = "SubCategoryName";
        //    drpItemSubCat.DataValueField = "SubCategoryName";
        //    drpItemSubCat.DataBind();
        //    drpItemSubCat.Items.Insert(0, "Select");
        //}




        protected void DrpItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DrpItemNamw.Text = DrpItemCode.Text;
            
        }

        






        protected void btnSave_Click(object sender, EventArgs e)
        {
            int res = 0;

            model.Itemcode = txtItemCode.Text;
            model.Itemname = txtItemName.Text;
            model.ManufacturerId = Convert.ToInt32(txtManufacturer.Text);
            model.Material = txtMaterial.Text;
            model.Itemtype = txtItemType.Text;
            model.Itemsubtype = txtItemSubType.Text;
            model.Color = txtColor.Text;
            model.UOM = txtUOM.Text;
            model.HSNcode = txtHSNCode.Text;
            model.GSTrate = Convert.ToDecimal(txtGSTRate.Text);
            model.Purchaseprice = Convert.ToDecimal(txtPurchaseCost.Text);
            model.Sellingprice = Convert.ToDecimal(txtSellingPrice.Text);
            model.Category = drpItemCat.Text;
          //  model.Subcategory = drpItemSubCat.Text;







            bal.SaveData(model);

            if (res > 0)
            {
                Response.Write("<script>alert('Save Successfully....')</script>");
            }
            else
            {

                Response.Write("<script>alert('Error Occured....')</script>");
            }
        }

        //protected void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    int res = 0;

        //    model.Itemcode = txtItemCode.Text;
        //    model.Itemname = txtItemName.Text;
        //    model.ManufacturerId = Convert.ToInt32(txtManufacturer.Text);
        //    model.Material = txtMaterial.Text;
        //    model.Itemtype = txtItemType.Text;
        //    model.Itemsubtype = txtItemSubType.Text;
        //    model.Color = txtColor.Text;
        //    model.UOM = txtUOM.Text;
        //    model.HSNcode = txtHSNCode.Text;
        //    model.GSTrate = Convert.ToDecimal(txtGSTRate.Text);
        //    model.Purchaseprice = Convert.ToDecimal(txtPurchaseCost.Text);
        //    model.Sellingprice = Convert.ToDecimal(txtSellingPrice.Text);
        //    model.Category = drpItemCat.Text;

        //  res=  bal.Update(model);

        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ItemCode = DrpItemCode.SelectedItem.Text;
            DataTable dt = new DataTable();

            dt= bal.SearchData(ItemCode);

            
            txtManufacturer.Text = dt.Rows[0]["ManufacturerId"].ToString();
            txtMaterial.Text = dt.Rows[0]["Material"].ToString();
            txtItemType.Text = dt.Rows[0]["ItemType"].ToString();
            txtItemSubType.Text = dt.Rows[0]["ItemSubType"].ToString();
            txtColor.Text = dt.Rows[0]["Color"].ToString();
            txtUOM.Text = dt.Rows[0]["UOM"].ToString();
            txtHSNCode.Text = dt.Rows[0]["HSNCODE"].ToString();
            txtGSTRate.Text = dt.Rows[0]["GSTRate"].ToString();
            txtPurchaseCost.Text = dt.Rows[0]["PurchaseCost"].ToString();
            txtSellingPrice.Text = dt.Rows[0]["SellingPrice"].ToString();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int res = 0;

            model.Itemcode = DrpItemCode.SelectedItem.Text;
            res=bal.DeleteData(model.Itemcode);

            if (res > 0)
            {
                Response.Write("<script>alert('Deleted Successfully....')</script>");
            }
            else
            {

                Response.Write("<script>alert('Error Occured....')</script>");
            }




        }

        protected void drpItemCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            drpItemSubCat.Enabled = true;

                int CategoryId =Convert.ToInt32( drpItemCat.SelectedValue);
                DataTable dt = new DataTable();
                dt = bal.GetBindItmSubCatagory(CategoryId);

                // Assuming you have a DropDownList called ddlYourDropdown in your ASP.NET markup
                drpItemSubCat.DataSource = dt;
                drpItemSubCat.DataTextField = "SubCategoryName";
                drpItemSubCat.DataValueField = "SubCategoryId";
                drpItemSubCat.DataBind();
                drpItemSubCat.Items.Insert(0, "Select");

        }

       

        //protected void drpItemCat_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    drpItemSubCat.Enabled = true;
        //    //binding

        //    int CategoryId = Convert.ToInt32(drpItemCat.SelectedValue);
        //    DataTable dt = new DataTable();
        //    dt = bal.GetBindItmSubCatagory(CategoryId);

        //    // Assuming you have a DropDownList called ddlYourDropdown in your ASP.NET markup
        //    drpItemSubCat.DataSource = dt;
        //    drpItemSubCat.DataTextField = "SubCategoryId";
        //    drpItemSubCat.DataValueField = "SubCategoryName";
        //    drpItemSubCat.DataBind();
        //    drpItemSubCat.Items.Insert(0, "Select");

        //}
    }
}