using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Charles_Hotel_2017101992
{
    public partial class CheckOutRoomForm_2017101992 : Form
    {
        public CheckOutRoomForm_2017101992()
        {
            dt = BLL_2017101992.RoomManager.GetUseRoomInfo();
            InitializeComponent();
            this.Load += new EventHandler(CheckOutRoomForm_2017101992_Load);
        }
        public DataTable dt;
        //检查数据
        private bool checkdata()
        {
            //定义入住和离开时间
            DateTime inTime = System.Convert.ToDateTime(DateTime.Parse(dtpIn.Text.ToString()).ToString("yyyy-MM-dd"));
            DateTime outTime = DateTime.Parse(dtpOut.Text.ToString());
            //检查入住时间
            if (outTime < inTime)
            {
                MessageBox.Show("离开时间不能小于入住时间!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpOut.Focus();
                return false;
            }
            return true;
        }
        
        private void CheckOutRoomForm_2017101992_Load(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    HouseNumberBox.Items.Add(dt.Rows[i]["房间号"].ToString());
                }
            }
        }
        //房间号事件
        private void HouseNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; 1 <= dt.Rows.Count - 1; i++)
            {
                if (HouseNumberBox.SelectedItem.ToString() == dt.Rows[i]["房间号"].ToString())
                {
                    ciMoneyBox.Text = dt.Rows[i]["价格"].ToString();
                    riaMoneyBox.Text = dt.Rows[i]["押金"].ToString();
                    dtpIn.Text = dt.Rows[i]["入住时间"].ToString();
                    TextName.Text = dt.Rows[i]["客户名称"].ToString();
                    string outTime = dtpOut.Text + string.Format("{0:T}", DateTime.Now);
                    TimeSpan ts1 = new TimeSpan(DateTime.Parse(outTime).Ticks);
                    TimeSpan ts2 = new TimeSpan(DateTime.Parse(dtpIn.Text).Ticks);
                    TimeSpan ts = ts1.Subtract(ts2);
                    int dayCount = ts.Days;
                    int hourCount = ts.Hours;
                    if (dayCount == 0 & hourCount < 24)
                    {
                        dayCount = 1;
                    }
                    double consumTotal = double.Parse(ciMoneyBox.Text.ToString()) * dayCount;
                    TotalMoneyBox.Text = consumTotal.ToString();
                    AccountMoneyBox.Text = System.Convert.ToString(consumTotal - double.Parse(riaMoneyBox.Text));
                    return;

                }
            }
        }
        //清除按钮
        public void ResetBtn_Click(object sender, EventArgs e)
        {
            dtpOut.Text = null;
            dtpIn.Text = null;
            TextName.Text = "";
        }
        //存储按钮
        public void SaveBtn_Click(object sender, EventArgs e)
        {
            if (checkdata() == false)
            {
                return;
            }
            string strTimeNow = string.Format("{0:T}", DateTime.Now);
            string inTime = dtpIn.Text.ToString();
            string outTime = dtpOut.Text.ToString() + strTimeNow;
            int inId = int.Parse(BLL_2017101992.RoomManager.GetInID(HouseNumberBox.SelectedItem.ToString()).Rows[0][0].ToString());
            Mouse_2017101992.CheckOutRoom checkOutRoom = new Mouse_2017101992.CheckOutRoom();
            checkOutRoom.OutId = DateTime.Now.ToString("yyyyMMddHHmmss");
            checkOutRoom.InId = inId;
            checkOutRoom.RoomId = Convert.ToInt32(HouseNumberBox.SelectedItem.ToString());
            checkOutRoom.Price = double.Parse(ciMoneyBox.Text);
            checkOutRoom.Foregift = double.Parse(riaMoneyBox.Text.ToString());
            checkOutRoom.Total = double.Parse(TotalMoneyBox.Text.ToString());
            checkOutRoom.Account = double.Parse(AccountMoneyBox.Text.ToString());
            checkOutRoom.InTime = DateTime.Parse(inTime);
            checkOutRoom.OutTime = DateTime.Parse(outTime);
            checkOutRoom.ClientName = TextName.Text.ToString();
            checkOutRoom.Oper = BLL_2017101992.RoleManager_2017101992.curUser.Name;
            checkOutRoom.Note = SomethingBox.Text.ToString();
            if (BLL_2017101992.RoomManager.InsertCheckOutRoomInfo(checkOutRoom))
            {
                MessageBox.Show("插入数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("插入数据失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
       //导出按钮
        private void printBtn_Click(object sender, EventArgs e)
        {
            string path = "C:\\发票单\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("----齐鲁大地----");
                sw.WriteLine("客户：" + TextName.Text);
                sw.WriteLine("住宿费：" + TotalMoneyBox.Text);
                sw.WriteLine("开票日期：" + DateTime.Now.ToString("yyyy-MM-dd"));
                sw.Close();
                MessageBox.Show("导出成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("请检查路径是否存在！");
            }
        }

    }
}
