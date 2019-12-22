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
    public partial class MainForm_2017101992 : Form
    {
        public MainForm_2017101992()
        {
            InitializeComponent();
        }
      // if (e.Button==toolBar_ButConnect)
        //{
        // 调用相应的菜单点击命令
       //menuItem_Connect.PerformClick()
       // }
       // else
        //{
      //  menuItem_Disconnect_Click(sender, e);
      //  }

private void miNewUser_Click(object sender, EventArgs e)
        {
            AddUserForm_2017101992 frm = new AddUserForm_2017101992();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            HelpAbout_2017101992 frm = new HelpAbout_2017101992();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RegisterRoomForm_2017101992 frm = new RegisterRoomForm_2017101992();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CheckOutRoomForm_2017101992 frm = new CheckOutRoomForm_2017101992();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            RoomForm_2017101992 frm = new RoomForm_2017101992();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ClientForm_2017101992 frm = new ClientForm_2017101992();
            frm.MdiParent = this;
            frm.Show();
        }

        private void miUserManage_Click(object sender, EventArgs e)
        {
            UserManagerForm_2017101992 frm = new UserManagerForm_2017101992();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MainForm_2017101992_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_2017101992_Load(object sender, EventArgs e)
        {
            //当前用户是普通员工，则因相应的菜单
            if (BLL_2017101992.RoleManager_2017101992.curUser.Role == 0) {
                miNewUser.Visible = false;
                miEditUser.Visible = false;
                miNewUser.Visible = false;


            }
        }
    }
}
