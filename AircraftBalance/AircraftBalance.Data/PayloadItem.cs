using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AircraftBalance.Data
{
    public class PayloadItem
    {
        [Key]
        public int PayloadItemId { get; set; }
        public string PayloadItemName { get; set; }
        public double PayloadItemWeight { get; set; }
        public double PayloadItemArm { get; set; }
        public double PayloadItemMoment => (PayloadItemArm * PayloadItemWeight) / 100;

        [ForeignKey("AircraftId")]
        public Aircraft Aircraft { get; set; }
        [Display(Name = "Aircraft")]
        public int AircraftId { get; set; }

        public PayloadItem()
        {
        }
        public PayloadItem(string itemName, double arm, int aircraftId)
        {
            AircraftId = aircraftId;
            PayloadItemName = itemName;
            PayloadItemArm = arm;
        }
    }
}
