using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_2017101992;

namespace BLL_2017101992
{
   public class RoomManager
    {
        //获取空房信息
        public static DataTable GetRoomInfo()
        {
            string sql = @"SELECT roomId AS 房间号,roomType AS房间类型,
                        roomFloor AS 层数,Price AS 价格,personNum AS 可入住人数,
                        inPerson AS 已入住人数,note AS 备注,
                        FROM Room WHERE inPerson=0";
            DataTable dt = DAL.DBOper.GetDataTable(sql);
            return dt;
        }
        public static DataTable GetUseRoomInfo()
        {
            string sql = @" SELECT roomId AS 房间号,price AS 价格,foregift AS 押金,inTime AS 入住时间,outTime AS 退房时间,clientName AS 客户名称,sex AS 性别,phone AS 电话号码,certType AS 证件类型,certId AS 证件号码,address AS 地址,personNum AS 入住人数,Oper AS 登记者 FROM RegisterRoom where delMark=0";
            DataTable dt = DAL.DBOper.GetDataTable(sql);
            return dt;
        }
        public static DataTable GetInID(string roomId)
        {
            string Sql = @"SELECT inId FROM RegisterRoom WHERE delMark = 0 AND roomId=" + roomId;
            DataTable dt = DAL.DBOper.GetDataTable(Sql);
            return dt;
        }
        public static bool InsertCheckOutRoomInfo(Mouse_2017101992.CheckOutRoom checkOutRoomInfo)
        {
            string sqlInsert = @"INSERT INTO CheckOutRoom VALUES(@outId, @inId, @outTime, @roomId, @clientName, @inTime,@price, @foregift, @total, @account, @note, @oper)";
            string sqlUpdateRegister = @"UPDATE RegisterRoom SET delMark=1 WHERE inId=@inId";
            string sqlUpdateRoom = @"UPDATE Room SET inPerson=0 WHERE roomId=@roomId";
            SqlParameter p1 = new SqlParameter("@outId", checkOutRoomInfo.OutId);
            SqlParameter p2 = new SqlParameter("@inId", checkOutRoomInfo.InId);
            SqlParameter p3 = new SqlParameter("@roomId", checkOutRoomInfo.RoomId);
            SqlParameter p4 = new SqlParameter("@price", double.Parse(Convert.ToString(checkOutRoomInfo.Price)));
            SqlParameter p5 = new SqlParameter("@foregift", double.Parse(Convert.ToString(checkOutRoomInfo.Foregift)));
            SqlParameter p6 = new SqlParameter("@total", double.Parse(Convert.ToString(checkOutRoomInfo.Total)));
            SqlParameter p7 = new SqlParameter("@account", double.Parse(Convert.ToString(checkOutRoomInfo.Account)));
            SqlParameter p8 = new SqlParameter("@inTime", checkOutRoomInfo.InTime);
            SqlParameter p9 = new SqlParameter("@outTime", checkOutRoomInfo.OutTime);
            SqlParameter p10 = new SqlParameter("@clientName", checkOutRoomInfo.ClientName);
            SqlParameter p11 = new SqlParameter("@oper", checkOutRoomInfo.Oper);
            SqlParameter p12 = new SqlParameter("@note", checkOutRoomInfo.Note);
            Mouse_2017101992.RegisterRoom registerInfo = new Mouse_2017101992.RegisterRoom();
            registerInfo.InId = checkOutRoomInfo.InId;
            SqlParameter n1 = new SqlParameter("@inId", registerInfo.InId);
            SqlParameter n2 = new SqlParameter("@roomId", checkOutRoomInfo.RoomId.ToString());
            if (DAL.DBOper.ExecuteCommmand(sqlInsert, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) == 1 &&
            DAL.DBOper.ExecuteCommmand(sqlUpdateRegister, n1) == 1 &&
            DAL.DBOper.ExecuteCommmand(sqlUpdateRoom, n2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //保存入住信息
        public static bool InsertRoomInfo(Mouse_2017101992.RegisterRoom registerRoomInfo)
        {
            //向RegisterRoom 表中插入数据
            string sqlInsert = @"INSERT INTO RegisterRoom VALUES
                      (@roomId,@price,@forgift,@inTime,@outTime,@clientName,
                      @sex,@phone,@certType,@certId,@address,@personNum,@Oper,@delMark)";
            string sqlUpdate = @"UPDATE Room SET inPerson=@inPerson WHERE roomId=@roomId";
            SqlParameter p1 = new SqlParameter("@roomId", registerRoomInfo.RoomId);
            SqlParameter p2 = new SqlParameter("@price", registerRoomInfo.Price);
            SqlParameter p3 = new SqlParameter("@forgift", registerRoomInfo.Foregift);
            SqlParameter p4 = new SqlParameter("@inTime", registerRoomInfo.InTime);
            SqlParameter p5 = new SqlParameter("@outTime", registerRoomInfo.OutTime);
            SqlParameter p6 = new SqlParameter("@clientName", registerRoomInfo.ClientName);
            SqlParameter p7 = new SqlParameter("@sex", registerRoomInfo.Sex);
            SqlParameter p8 = new SqlParameter("@phone", registerRoomInfo.Phone);
            SqlParameter p9 = new SqlParameter("@certType", registerRoomInfo.CertType);
            SqlParameter p10 = new SqlParameter("@certId", registerRoomInfo.CertId);
            SqlParameter p11 = new SqlParameter("@address", registerRoomInfo.Address);
            SqlParameter p12 = new SqlParameter("@personNum", registerRoomInfo.PersonNum);
            SqlParameter p13 = new SqlParameter("@Oper", registerRoomInfo.Oper);
            SqlParameter p14 = new SqlParameter("@delMark", registerRoomInfo.DelMark);
            SqlParameter[] paramArray = new SqlParameter[] {
                   p1,
                   p2,
                   p3,
                   p4,
                   p5,
                   p6,
                   p7,
                   p8,
                   p9,
                   p10,
                   p11,
                   p12,
                   p13,
                   p14
                  };
            Mouse_2017101992.RoomInfo roomInfo = new Mouse_2017101992.RoomInfo();
            roomInfo.InPerson = registerRoomInfo.PersonNum;
            SqlParameter n1 = new SqlParameter("@roomId", registerRoomInfo.RoomId);
            SqlParameter n2 = new SqlParameter("@inPerson", roomInfo.InPerson);
            if (DAL.DBOper.ExecuteCommmand(sqlInsert, paramArray) == 1 && DAL.DBOper.ExecuteCommmand(sqlUpdate, n1, n2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
