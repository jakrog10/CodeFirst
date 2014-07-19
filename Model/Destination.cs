using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }

        public byte[] Photo { get; set; }

        public List<Lodging> Lodgings { get; set; }

    }
}
