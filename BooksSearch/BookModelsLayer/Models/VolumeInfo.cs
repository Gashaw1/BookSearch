using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookModelsLayer.Models
{
    public class items
    {
        public string kind { get; set; }
        public string id { get; set; }
        public string etag { get; set; }
        public string selfLink { get; set; }
        public volumeInfo volumeInfo { get; set; }    
    }
    public class volumeInfo
    {
        public string title { get; set; }
        public Authors authors { get; set; }    
       
    }
}
