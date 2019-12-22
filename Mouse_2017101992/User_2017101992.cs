using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouse_2017101992
{
   public  class User_2017101992
    {            //私有字段
            private string name;
            private string pwd;
            private int role;
        //属性

        public string Name { get => name; set => name = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public int Role { get => role; set => role = value; }
        //不带参数的构造函数
        public User_2017101992()
            {
                Name = "";
                Pwd = "";
                Role = 0;
            }
            //带参数的构造函数
            public User_2017101992(string n, string p, int r)
            {
                Name = n;
                Pwd = p;
                Role = r;
            }

    }
    }




