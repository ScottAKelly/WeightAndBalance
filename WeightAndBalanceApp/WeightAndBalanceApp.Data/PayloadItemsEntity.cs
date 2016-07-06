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

        [ForeignKey("PayloadId")]
        public PayloadEntity Payload { get; set; }
        [Display(Name ="Payload")]
        public int PayloadId { get; set; }

        [ForeignKey("AircraftId")]
        public AircraftEntity Aircraft { get; set; }
        [Display(Name ="Aircraft")]
        public int AircraftId { get; set; }
    }
}