using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Mouse_2017101992;

namespace BLL_2017101992
{
    public class UserManager
    {
        public static Mouse_2017101992.User_2017101992 GetUser(string name, string pwd)
        {
            Mouse_2017101992.User_2017101992 user = null;
            string sql = "select *from UserDetails where userName=\'" + name + "\' and userPwd=\'" + pwd + "\'";
            SqlDataReader reader = DAL.DBOper.GetReader(sql);
            if (reader.Read())
            {
                user = new Mouse_2017101992.User_2017101992();
                user.Name = System.Convert.ToString(reader["userName"]);
                user.Pwd = System.Convert.ToString(reader["userPwd"]);
            }
            reader.Close();
            return user;
        }
        public static bool AddUser(Mouse_2017101992.User_2017101992 user_2017101992)
        {
            string sql = "insert into UserDetails values(@name, @pwd,@role)";
            //创建参数对象
            SqlParameter p1 = new SqlParameter("@name", user_2017101992.Name);
            SqlParameter p2 = new SqlParameter("@pwd", user_2017101992.Pwd);
            SqlParameter p3 = new SqlParameter("@role", user_2017101992.Role);
            //如果添加成功，则返回True
            if (DAL.DBOper.ExecuteCommmand(sql, p1, p2, p3) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
   
}
