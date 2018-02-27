using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Models
{

    [Table(" Models")]
    public class Model
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        // foreign key property. Now we do not have to load a make object
        public int MakeId { get; set; }
        // navigation property 
        public Make Make { get; set; }
    }
}
