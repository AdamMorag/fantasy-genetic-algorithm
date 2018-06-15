using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace fantasy_genetic_algorithm.Models
{    
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Role
    {        
        g,
        d,
        m,
        a
    }
}
