using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AircraftBalance.Data
{
    public class Payload
    {
        [Key, ForeignKey("Aircraft")]
        public int PayloadId { get; set; }
        public double PayloadWeight { get; set; }
        public double PayloadArm { get; set; }
        public double PayloadMoment { get; set; }
        public Aircraft Aircraft { get; set; }
        [ForeignKey("PayloadItemId")]
        public IEnumerable<PayloadItem> PayloadItems { get; set; }
        [Display(Name = "Payload Item")]
        public int PayloadItemId { get; set; }

        public Payload(double arm, double weight, double moment)
        {
            PayloadArm = arm;
            PayloadWeight = weight;
            PayloadMoment = moment;
        }
    }
}
