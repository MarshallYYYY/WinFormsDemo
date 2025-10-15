using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLayer
    {
        private readonly DALayer dal;
        public BLLayer()
        {
            dal = new DALayer();
        }
        public List<Owner> FindOwners(string name)
        {
            return dal.FindOwners(name);
        }
        public Owner GetOwnerById(int id)
        {
            return dal.GetOwnerById(id);
        }
        private (string info, bool isSuccess) RegularData(Owner owner)
        {
            string info = "";
            //2-4个中文
            string regularName = "^[\u4e00-\u9fa5]{2,4}$";
            //11位数字
            string regularPhone = @"^\d{11}$";
            // 只能是 1-6 的数字
            string regularBuildingNum = @"^[1-6]$";
            // 只能是 1-3 的数字
            string regularUnitNum = @"^[1-3]$";
            // 12层，每层有4户
            string regularRoomNum = @"^([1-9]0[1-4]|1[0-2]0[1-4])$";

            if (!Regex.IsMatch(owner.Name, regularName))
                info += "姓名应为2-4个汉字！\n";
            if (!Regex.IsMatch(owner.Phone, regularPhone))
                info += "手机号应为11位数字！\n";
            if (!Regex.IsMatch(owner.BuildingNum.ToString(), regularBuildingNum))
                info += "楼号应为1-6的数字！\n";
            if (!Regex.IsMatch(owner.UnitNum.ToString(), regularUnitNum))
                info += "单元号应为1-3的数字！\n";
            if (!Regex.IsMatch(owner.RoomNum.ToString(), regularRoomNum))
                info += "房间号输入有误！\n";

            return (info, info == "");
        }
        public (string info, bool isSuccess) Add(Owner owner)
        {
            (string info, bool isSuccessRegular) = RegularData(owner);
            bool isSuccess;
            if (isSuccessRegular)
            {
                isSuccess = dal.Add(owner);
                if (isSuccess)
                    info = "添加成功！";
                else
                    info = "添加失败！";
                return (info, isSuccess);
            }
            return (info, isSuccessRegular);
        }
        public (string info, bool isSuccess) Edit(Owner newOwner)
        {
            (string info, bool isSuccessRegular) = RegularData(newOwner);
            bool isSuccess;
            if (isSuccessRegular)
            {
                isSuccess = dal.Edit(newOwner);
                if (isSuccess)
                    info = "修改成功！";
                else
                    info = "修改失败！";
                return (info, isSuccess);
            }
            return (info, isSuccessRegular);
        }
        public bool Delete(int id)
        {
            return dal.Delete(id);
        }
    }
}
