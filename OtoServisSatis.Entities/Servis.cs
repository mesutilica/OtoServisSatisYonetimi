using System;

namespace OtoServisSatis.Entities
{
    public class Servis : IEntity
    {
        public int Id { get; set; }
        public DateTime ServiseGelisTarihi { get; set; }
        public string AracSorunu { get; set; }
        public decimal ServisUcreti { get; set; }
        public DateTime ServistenCikisTarihi { get; set; }
        public string YapilanIslemler { get; set; }
        public bool GarantiKapsamindaMi { get; set; }
        public string AracPlaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string KasaTipi { get; set; }
        public string SaseNo { get; set; }
        public string Notlar { get; set; }
    }
}
