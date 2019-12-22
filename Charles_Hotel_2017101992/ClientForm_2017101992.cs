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
    public partial class ClientForm_2017101992 : Form { 
   
        public ClientForm_2017101992()
        {
            InitializeComponent();
        }

        private void ClientForm_2017101992_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotelDataSet.RegisterRoom”中。您可以根据需要移动或删除它。
            this.registerRoomTableAdapter.Fill(this.hotelDataSet.RegisterRoom);

        }
        public void btnQuery_Click(Object sender, EventArgs e)
        {
            Query();
        }

        public void btnSave_Click(Object sender, EventArgs e)
        {
            int num = clientGridView.SelectedRows[0].Index;
            var row = this.hotelDataSet.RegisterRoom.Rows[clientGridView.SelectedRows[0].Index];
            var clientName = textClientName.Text;
            var sex = false;
            if (rbFemale.Checked)
            {
                sex = true;
            }
            var phone = textPhone.Text;
            var certtype = cmbCerType.SelectedItem.ToString();
            var certId = textCerId.Text;
            var address = textAddress.Text;
            var personNum = textPersonNum.Text;
            row["clientName"] = clientName;
            row["sex"] = sex;
            row["phone"] = phone;
            row["certType"] = certtype;
            row["certId"] = certId;
            row["address"] = address;
            row["personNum"] = personNum;
            registerRoomTableAdapter.Update(this.hotelDataSet.RegisterRoom);
            hotelDataSet.RegisterRoom.AcceptChanges();
        }

        public void ClientGridView_Selection_Changed(Object sender, EventArgs e)
        {
            var rows = clientGridView.SelectedRows;
            if (rows.Count == 0)
            {
                textClientName.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                textPhone.Text = "";
                cmbCerType.SelectedItem = "";
                textCerId.Text = "";
                textCerId.Text = "";
                textPersonNum.Text = "";
                BtnSave.Enabled = false;
                return;
            }
            BtnSave.Enabled = true;
            var row = rows[0];
            textClientName.Text = System.Convert.ToString(row.Cells[0].Value);
            if (bool.Parse(row.Cells[7].Value.ToString()) == false)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            textPhone.Text = System.Convert.ToString(row.Cells[8].Value);
            cmbCerType.SelectedItem = row.Cells[9].Value;
            textCerId.Text = System.Convert.ToString(row.Cells[10].Value);
            textAddress.Text = System.Convert.ToString(row.Cells[11].Value);
            textPersonNum.Text = System.Convert.ToString(row.Cells[12].Value);
        }

        public void ClientGridView_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (e.Value.ToString() == "ture")
                {
                    e.Value = "女";
                }
                else
                {
                    e.Value = "男";
                }
            }
        }

        private void Query()
        {
            var clients = (from item in this.hotelDataSet.RegisterRoom where item.
                           
                           clientName.Contains(textQueryName.Text) select item).ToList();
            clientGridView.DataSource = clients;
        }
    }
}

