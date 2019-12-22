using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_2017101992;
namespace Charles_Hotel_2017101992
{
    public partial class RegisterRoomForm_2017101992 : Form
    {
        public RegisterRoomForm_2017101992()
        {
            InitializeComponent();
            IdTypeBox.SelectedIndex = 0;
            IdBox.GotFocus += IdBox_GotFocus;
            this.Load += new EventHandler(RegisterRoomForm_2017101992_Load);
        }

        private void RegisterRoomForm_2017101992_Load(object sender, EventArgs e)
        {
            //在操作员文本中显示登录用户名
            OpBox.Text = BLL_2017101992.RoleManager_2017101992.curUser.Name;
            //获取空房间列表
            DataTable dt = BLL_2017101992.RoomManager.GetRoomInfo();
            //判断是否有空房间
            if (dt.Rows.Count != 0)
            {
                dvgRoomList.DataSource=dt;
            }
            else
            {
                MessageBox.Show("已经没有空余房间了", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void IdBox_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
        }
        //重置按钮
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            RoomNumberBox.Text = "";
            dtpInTime.Text = "";
            personNameBox.Text = "";
            //IdBox.Text = "";
            AddressBox.Text = "";
            OpBox.Text = "";
            ciMoneyBox.Text = "";
            dtpOutTime.Text = "";
            rbMale.Checked = true;
            //IdBox.Text = "";
            IdTypeBox.SelectedIndex = 0;
            PhoneBox.Text = "";
            riaMoneyBox.Text = "";
            PersonNumberBox.Text = "";
        }
        private void IdTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (IdTypeBox.SelectedIndex)
            {
                case 0:IdBox.Text = "居民身份证";break;
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //获取当前时间
            string strTimeNow = string.Format("{0:T}", DateTime.Now);
            //获取入住时间
            string inTime = dtpInTime.Text.ToString() + strTimeNow;
            //获取离开时间
            string outTime = dtpOutTime.Text.ToString() + strTimeNow;
            //获取时间
            bool sex = default(bool);
            //获取性别
             if (rbMale.Checked)
                {
                    sex = false;
                 }
                else
                {
                     sex = true;
                }
            //定义Mouser对像
            Mouse_2017101992.RegisterRoom registerInfo = new Mouse_2017101992.RegisterRoom();
            registerInfo.RoomId = IdBox.Text.ToString();
            registerInfo.Price = double.Parse(ciMoneyBox.Text.ToString());
            registerInfo.Foregift = double.Parse(riaMoneyBox.Text.ToString());
            registerInfo.InTime = DateTime.Parse(inTime);
            registerInfo.OutTime = DateTime.Parse(outTime);
            registerInfo.ClientName = personNameBox.Text.ToString();
            registerInfo.Sex = sex;
            registerInfo.Phone = PhoneBox.Text.ToString();
            registerInfo.CertType = IdTypeBox.Text.ToString();
            registerInfo.ClientName = IdBox.Text.ToString();
            registerInfo.PersonNum = int.Parse(personNameBox.Text.ToString());
            registerInfo.Oper = OpBox.Text.ToString();
            registerInfo.Address = AddressBox.Text.ToString();
            registerInfo.DelMark = 0;
            //插入数据
            //if (checkdata())
            //{

            //}
        }

        
    }
}
