using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class DALayer
    {
        public List<Owner> FindOwners(string name)
        {
            using (OwnerDbContext context = new OwnerDbContext())
                return context.Owners.Where(o => o.Name.Contains(name)).ToList();
        }
        public bool Add(Owner owner)
        {
            using (OwnerDbContext context = new OwnerDbContext())
            {
                context.Owners.Add(owner);
                int count = context.SaveChanges();
                return count == 1;
            }
        }
        public Owner GetOwnerById(int id)
        {
            using (OwnerDbContext context = new OwnerDbContext())
                return context.Owners.Find(id);
        }
        public bool Edit(Owner newOwner)
        {
            using (OwnerDbContext context = new OwnerDbContext())
            {
                Owner owner = context.Owners.Find(newOwner.Id);

                // 方案一：把属性挨个赋值
                //owner.Name = newOwner.Name;
                //owner.Sex = newOwner.Sex;
                //owner.Phone = newOwner.Phone;
                //owner.BuildingNum = newOwner.BuildingNum;
                //owner.UnitNum = newOwner.UnitNum;
                //owner.RoomNum = newOwner.RoomNum;
                // ...

                // 方案二：
                //context.Entry(owner).State = EntityState.Modified;
                context.Entry(owner).CurrentValues.SetValues(newOwner);

                // 可选：排除某些字段不被更新
                // context.Entry(owner).Property(x => x.Id).IsModified = false;

                int count = context.SaveChanges();
                return count == 1;
            }
        }
        public bool Delete(int id)
        {
            using (OwnerDbContext context = new OwnerDbContext())
            {
                Owner owner = context.Owners.Find(id);
                context.Owners.Remove(owner);
                int count = context.SaveChanges();
                return count == 1;
            }
        }
    }
}
