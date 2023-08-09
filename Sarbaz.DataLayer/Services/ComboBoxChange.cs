using System.Data.SqlClient;
using System.Data;
using Sarbaz.DataLayer.Repositories;
using System;

namespace Sarbaz.DataLayer.Services
{
    
    public class ComboBoxChange : IComboBoxChange
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Soldier;Integrated Security = True");

        public DataTable Education()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Education", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--تحصیلات--" };
            dt.Rows.InsertAt(dr, 0);
            return dt;
        }
        public DataTable Grade()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Grade", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--درجه--" };
            dt.Rows.InsertAt(dr, 0);
            return dt;
        }
        public DataTable Raste()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Raste", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--رسته--" };
            dt.Rows.InsertAt(dr, 0);
            return dt;
        }


        public DataTable refreshdata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Tbl_Ostan", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--انتخاب استان--" };
            dt.Rows.InsertAt(dr, 0);
            return dt;
        }

        public DataTable refreshstate(int countryid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Tbl_Shahrestan where OstanID= @countryid", con);
            cmd.Parameters.AddWithValue("@countryid", countryid);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close(); 
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0,0,"--انتخاب شهر--" };
            dt.Rows.InsertAt(dr, 0);
            return dt;
        }
        public DataTable Unit()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Unit", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--گردان/واحد--" };
            dt.Rows.InsertAt(dr, 0);
            return dt;
        }
    }
}
