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
    public partial class RoomForm_2017101992 : Form
    {
        public RoomForm_2017101992()
        {
            InitializeComponent();
        }

        private void RoomForm_2017101992_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotelDataSet.RegisterRoom”中。您可以根据需要移动或删除它。
            this.registerRoomTableAdapter.Fill(this.hotelDataSet.RegisterRoom);
            // TODO: 这行代码将数据加载到表“hotelDataSet.Room”中。您可以根据需要移动或删除它。
            this.roomTableAdapter.Fill(this.hotelDataSet.Room);

        }
        public void roomDridView_SelectedRows(Object sender, EventArgs e)
        {
            var rooms = roomGridView.SelectedRows;
            if (rooms.Count == 0)
            {
                return;
            }
            var roomId = rooms[0].Cells[0].Value;
            var clients = from client in hotelDataSet.RegisterRoom
                          where client.roomId == roomId.ToString()
                          where client.delMark == false
                          select client;
            clientGridView.DataSource = clients.AsDataView();

        }
        public void clinetGridView_CellFromatting(Object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
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
    }
}