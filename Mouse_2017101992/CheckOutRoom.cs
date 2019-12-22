using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouse_2017101992
{
   public class CheckOutRoom
    {
        private string outId;
        private int inId;
        private DateTime outTime;
        private DateTime inTime;
        private int roomId;
        private string clientName;
        private string note;
        private string oper;
        private double price;
        private double foregift;
        private double total;
        private double account;

        public string OutId { get => outId; set => outId = value; }
        public int InId { get => inId; set => inId = value; }
        public DateTime OutTime { get => outTime; set => outTime = value; }
        public DateTime InTime { get => inTime; set => inTime = value; }
        public int RoomId { get => roomId; set => roomId = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string Note { get => note; set => note = value; }
        public string Oper { get => oper; set => oper = value; }
        public double Price { get => price; set => price = value; }
        public double Foregift { get => foregift; set => foregift = value; }
        public double Total { get => total; set => total = value; }
        public double Account { get => account; set => account = value; }
        //属性

    }
}
