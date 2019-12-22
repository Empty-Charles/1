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
    public partial class UserManagerForm_2017101992 : Form
    {
        public UserManagerForm_2017101992()
        {
            InitializeComponent();
            this.Load += new EventHandler(UserManagerForm_2017101992_Load);
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            DataRow row = hotelDataSet.UserDetails.Rows[dvgUsers.SelectedRows[0].Index];
            row["userPwd"] = textPwd.Text;
            row["Role"] = textRole.Text;
            userDetailsTableAdapter.Update(hotelDataSet.UserDetails);
            hotelDataSet.UserDetails.AcceptChanges();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除此行数据吗?", "提示",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
           DialogResult.OK)
            {
                DataRow delrow = hotelDataSet.UserDetails.Select("userName=\'" + textUserName.Text + "\'")[0];
                delrow.Delete();
                userDetailsTableAdapter.Update(hotelDataSet.UserDetails);
                hotelDataSet.UserDetails.AcceptChanges();
            }
        }

        private void UserManagerForm_2017101992_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotelDataSet.UserDetails”中。您可以根据需要移动或删除它。
            this.userDetailsTableAdapter.Fill(this.hotelDataSet.UserDetails);

        }

        private void dvgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selRow = dvgUsers.SelectedRows[0];
            textUserName.Text = System.Convert.ToString(selRow.Cells[0].Value.ToString());
            textPwd.Text = System.Convert.ToString(selRow.Cells[1].Value.ToString());
            textRole.Text = System.Convert.ToString(selRow.Cells[2].Value.ToString());
        }
    }
}
