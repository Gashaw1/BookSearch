namespace BookModelsLayer.Models
{
    public class AccessInfo
    {
        public string country { get; set; }
        public string ViewAbility { get; set; }
        public bool emeddable { get; set; }
        public bool publicDomain { get; set; }
        public string textToSpeechPermission { get; set; }
        public Epub epub { get; set; }
        public Pdf pdf { get; set; }
        public string ReaderLink { get; set; }
        public string AccessViewStatus { get; set; }
        public bool quteSharingAllowed { get; set; }
       
    }

    public class Pdf
    {
        public bool Isabaliable { get; set; }
    }

    public class Epub
    {
        public bool IsAvaliable { get; set; }
    }
}