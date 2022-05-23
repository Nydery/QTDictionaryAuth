namespace QTDictionaryAuth.AspMvc.Models
{
    public class EntryModel : IdentityModel
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
    }
}
