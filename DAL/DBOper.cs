using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DBOper
    {
        //连接对象的私有字段
        private static SqlConnection conn;
        //链接对象的属性
        public static SqlConnection Connection
        {
            get
            {
                if (conn == null)
                {
                    //从配置文件中获取连接字符串
                    string connStr = ConfigurationManager.ConnectionStrings["HotelConStr"].ConnectionString;
                    conn = new SqlConnection(connStr);
                    conn.Open();
                }else if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }else if(conn.State == System.Data.ConnectionState.Broken){
                    conn.Close();
                    conn.Open();
                }
                return conn;
            }
        }//不带参数的执行
        public static int ExecuteCommmand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            return cmd.ExecuteNonQuery();
        }
        //带参数的执行
        public static int ExecuteCommmand(string sql,params SqlParameter[]values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }
        //不带参数的获取数据读取器
        public static SqlDataReader GetReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            return cmd.ExecuteReader();
        }
        //带参数的获取数据读取器
        public static SqlDataReader GetReader(string sql,params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteReader();
        }
        //不带参数的数据采集表
        public static DataTable GetDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, Connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        //带参数的数据采集表
        public static DataTable GetDataTable(string sql,params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

    }
}
