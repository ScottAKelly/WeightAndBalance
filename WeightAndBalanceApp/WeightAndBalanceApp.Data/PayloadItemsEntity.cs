using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeightAndBalanceApp.Data
{
    public class PayloadItemsEntity
    {
        [Key]
        public int PayloadItemId { get; set; }
        public string PayloadItemName { get; set; }
        public float PayloadItemWeight { get; set; }
        public float PayloadItemMoment { get; set; }
        public float PayloadItemArm { get; set; }
        public PayloadEntity Payload { get; set; }
        public AircraftEntity Aircraft { get; set; }
    }
}