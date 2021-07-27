using System;
using System.ComponentModel.DataAnnotations;

namespace MusicShop.Models
{
    public class LayoutViewModel
    {
        [StringLength(Int32.MaxValue, MinimumLength = 1)]
        public string Query { get; set; }
    }
}
