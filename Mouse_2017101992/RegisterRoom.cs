using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouse_2017101992
{
   public class RegisterRoom
    {
        private int inId;
        private string roomId;
        private double price;
        private double foregift;
        private DateTime inTime;
        private DateTime outTime;
        private string clientName;
        private string phone;
        private bool sex;
        private string certType;
        private string certId;
        private string address;
        private int personNum;
        private string oper;
        private int delMark;

        public int InId { get => inId; set => inId = value; }
        public string RoomId { get => roomId; set => roomId = value; }
        public double Price { get => price; set => price = value; }
        public double Foregift { get => foregift; set => foregift = value; }
        public DateTime InTime { get => inTime; set => inTime = value; }
        public DateTime OutTime { get => outTime; set => outTime = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string Phone { get => phone; set => phone = value; }
        public bool Sex { get => sex; set => sex = value; }
        public string CertType { get => certType; set => certType = value; }
        public string CertId { get => certId; set => certId = value; }
        public string Address { get => address; set => address = value; }
        public int PersonNum { get => personNum; set => personNum = value; }
        public string Oper { get => oper; set => oper = value; }
        public int DelMark { get => delMark; set => delMark = value; }
        

    }
}
