using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charles_Hotel_2017101992
{
    public partial class AddUserForm_2017101992 : Form
    {
        public AddUserForm_2017101992()
        {
            InitializeComponent();
        }
        //添加
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string strName = textName.Text;
            string strPwd = textPwd.Text;
            //检查用户名和密码是否为空；
            if (string.IsNullOrEmpty(strName))
            {
                MessageBox.Show("请输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(strPwd))
            {
                MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPwd.Focus();
                return;
            }
            //权限0为员工，1为管理员；
            int role = 0;
            if (rbAdmin.Checked == true)
            {
                role = 1;
            }
            try
            {
                Mouse_2017101992.User_2017101992 user_2017101992 = new Mouse_2017101992.User_2017101992(strName, strPwd, role);
                if (BLL_2017101992.UserManager.AddUser(user_2017101992))
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("添加失败");
            }
            //MessageBox.Show(strName + "" + strPwd + "" + role);
         }
        //取消
        public void CancleBtn_Click(object sender, EventArgs e)
        {//清空数据
            //textName.Text = "";
            //textPwd.Text = "";
            //rbEmp.Checked = true;
            //关闭窗口；
            this.Close();

        }

      
    }
}
