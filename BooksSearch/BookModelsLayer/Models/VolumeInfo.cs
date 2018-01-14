using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookModelsLayer.Models
{
    public class VolumeInfo
    {
        public string Title { get; set; }
        public List<Authors> _Author { get; set; }
        public string Publisher { get; set; }
        public string PublisDate { get; set; }
        public string Description { get; set; }
        public List<IndustryIdentifier> industryIdentifiers { get; set; }
        public ReadingModes _ReadingModes { get; set; }
        public int PageCount { get; set; }
        public string PrintType { get; set; }
        public List<Catagorie> Catagories { get; set; }
        public string MaturityRating { get; set; }
        public bool alowAnonLogging { get; set; }
        public string contentVersion { get; set; }
        public List<string> ImagesLinks { get; set; }
        public string Language { get; set; }
        public string PreviewLink { get; set; }
        public string InfoLink { get; set; }
        public string canonicalVolumeLink { get; set; }
        public SaleInfo _SaleInfo { get; set; }
        public AccessInfo _AccessIno { get; set; }
        public SearchInfo _serarchInfo { get; set; }
    }
}
