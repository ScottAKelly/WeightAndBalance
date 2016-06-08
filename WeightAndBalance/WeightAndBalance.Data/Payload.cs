using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeightAndBalance.Data
{
    public class Payload
    {
        [Key]
        public int PayloadId { get; set; }
        public IEnumerable<PayloadItems> PayloadItems { get; set; }
    }
}