using System.ComponentModel.DataAnnotations;

namespace QTDictionaryAuth.WebApi.Models
{
    public class EditEntry
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
    }
}
