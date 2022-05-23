namespace QTDictionaryAuth.Logic.Entities
{
    [Table("Entry", Schema = "App")]
    [Index(nameof(Key), IsUnique = true)]
    public class Entry : VersionEntity
    {
        [Required]
        [MaxLength(255)]
        public string Key { get; set; } = string.Empty;
        [MaxLength(2048)]
        public string? Value { get; set; }
    }
}
