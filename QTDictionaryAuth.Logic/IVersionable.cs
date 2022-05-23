//@CodeCopy
//MdStart

namespace QTDictionaryAuth.Logic
{
    public partial interface IVersionable : IIdentifyable
    {
        byte[]? RowVersion { get; }
    }
}
//MdEnd
