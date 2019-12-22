using System;
using System.Windows.Forms;
namespace Charles_Hotel_2017101992
{
    public partial class LoginForm_2017101992 : Form
    {
        public LoginForm_2017101992()
        {
            InitializeComponent();
        }
        //登录系统
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string strName = textName.Text;
            string strPwd = textPwd.Text;
            //检查用户名或者密码是否为空
            if (string.IsNullOrEmpty(strName))
            {
                MessageBox.Show("用户名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(strPwd))
            {
                MessageBox.Show("密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPwd.Focus();
                return;
            }
            //检验是否为客户
            //if (strName == "zhangsan" && strPwd == "123")

            Mouse_2017101992.User_2017101992 user = BLL_2017101992.UserManager.GetUser(strName, strPwd);
            if (user == null)
            {
                MessageBox.Show("错误的用户名或密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BLL_2017101992.RoleManager_2017101992.curUser = user;
                this.Hide();
                MainForm_2017101992 frm_2017101992 = new MainForm_2017101992();
                frm_2017101992.Show();
            }
                //BLL_2017101992.RoleManager_2017101992.curUser.Pwd = strPwd;
                //BLL_2017101992.RoleManager_2017101992.curUser.Role = 1;//管理员权限
                //MessageBox.Show("欢迎使用本系统!")
        }
        //退出系统
        private void DropBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                textPwd.Focus();
            }
        }

        private void textPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(new object(), new EventArgs());
            }
        }
    }
}
