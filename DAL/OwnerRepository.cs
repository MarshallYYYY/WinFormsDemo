using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDemo.Models;

namespace WinFormsDemo.DAL
{
    public class OwnerRepository
    {
        public List<Owner> FindOwners(string name)
        {
            using (DemoDbContext context = new DemoDbContext())
                return context.Owners.Where(o => o.Name.Contains(name)).ToList();
        }
        public bool Add(Owner owner)
        {
            using (DemoDbContext context = new DemoDbContext())
            {
                context.Owners.Add(owner);
                int count = context.SaveChanges();
                return count == 1;
            }
        }
        public Owner GetOwnerById(int id)
        {
            using (DemoDbContext context = new DemoDbContext())
                return context.Owners.Find(id);
        }
        public bool Edit(Owner newOwner)
        {
            using (DemoDbContext context = new DemoDbContext())
            {

                // 方案一：把属性挨个赋值
                //owner.Name = newOwner.Name;
                //owner.Sex = newOwner.Sex;
                //owner.Phone = newOwner.Phone;
                //owner.BuildingNum = newOwner.BuildingNum;
                //owner.UnitNum = newOwner.UnitNum;
                //owner.RoomNum = newOwner.RoomNum;
                // ...

                // 方案二：一开始用的方案
                //Owner owner = context.Owners.Find(newOwner.Id);
                //context.Entry(owner).CurrentValues.SetValues(newOwner);

                // 方案三：最简洁
                context.Entry(newOwner).State = EntityState.Modified;

                // 可选：排除某些字段不被更新
                // context.Entry(owner).Property(x => x.Id).IsModified = false;

                int count = context.SaveChanges();
                return count == 1;
            }
        }
        public bool Delete(int id)
        {
            using (DemoDbContext context = new DemoDbContext())
            {
                Owner owner = context.Owners.Find(id);
                context.Owners.Remove(owner);
                int count = context.SaveChanges();
                return count == 1;
            }
        }
    }
}
