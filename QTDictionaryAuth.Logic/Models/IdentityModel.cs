//@CodeCopy
//MdStart

namespace QTDictionaryAuth.Logic.Models
{
    public abstract partial class IdentityModel : IIdentifyable
    {
        /// <summary>
        /// ID of the entity (primary key)
        /// </summary>
        public virtual int Id { get; set; }
    }
}
//MdEnd
