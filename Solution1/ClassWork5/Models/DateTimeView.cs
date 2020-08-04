using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassWork5.Models
{
    public class DateTimeView
    {
        [UIHint("datetime")]
        public DateTime dateTime { get; set; }
    }
}