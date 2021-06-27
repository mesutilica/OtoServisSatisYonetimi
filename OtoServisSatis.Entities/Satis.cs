using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    public class Satis : IEntity
    {
        public int Id { get; set; }
        public int AracId { get; set; }
        public int MusteriId { get; set; }
        public decimal SatisFiyati { get; set; }
        public DateTime SatisTarihi { get; set; }
        public virtual Arac Arac { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
