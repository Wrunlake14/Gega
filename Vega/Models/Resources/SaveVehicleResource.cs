using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Models.Resources
{

    public class ContactResource
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string Phone { get; set; }

    }

    // used for updatintg and saving. 
    public class SaveVehicleResource
    {
        public int Id { get; set; }

        public int ModelId { get; set; }
       
        public bool IsRegistered { get; set; }
        [Required]
        public ContactResource Contact { get; set; }

      

        public ICollection<int> Features { get; set; }

        public SaveVehicleResource()
        {
            Features = new Collection<int>();


        }

      
    }
}
