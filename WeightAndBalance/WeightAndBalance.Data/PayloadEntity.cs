using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WeightAndBalance.Data
{
    public class PayloadEntity
    {
        [Key]
        public int PayloadId { get; set; }
        [ForeignKey("PayloadItems")]
        public IEnumerable<PayloadItemsEntity> PayloadItems { get; set; }
        [ForeignKey("Aircraft")]
        public AircraftEntity Aircraft { get; set; }
    }
}