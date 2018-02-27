﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Models.Resources
{
    
        // No association to Domain Classes
        public class VehicleResource
        {
            public int Id { get; set; }

            
            // navigation property
            public KeyValuePairResource Model { get; set; }
        public KeyValuePairResource Make { get; set; }
        public bool IsRegistered { get; set; }
            public ContactResource Contact { get; set; }
           
            public DateTime LastUpdate { get; set; }

            public ICollection<KeyValuePairResource> Features { get; set; }

            public VehicleResource()
            {
                Features = new Collection<KeyValuePairResource>();
            }

        }

        }

