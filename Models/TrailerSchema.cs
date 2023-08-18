using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_balk.Utils;
namespace data_balk.Models
{
    public class Trailer_model
    {
        public int Id { get; set; } = 0;

        public string Img_url { get; set; } = "";
        public string Description { get; set; } = "";

        public string Capacity { get; set; } = "";

        public string Fleet_no { get; set; } = "";

        public bool IsAvailable { get; set; } = false;
        public bool IsRented { get; set; } = false;

    }
}