using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("Owner")]
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public int BuildingNum { get; set; }
        public int UnitNum { get; set; }
        public int RoomNum { get; set; }
    }
}
