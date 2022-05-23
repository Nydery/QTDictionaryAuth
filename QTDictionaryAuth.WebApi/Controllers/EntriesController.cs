using QTDictionaryAuth.Logic;
using QTDictionaryAuth.Logic.Entities;

namespace QTDictionaryAuth.WebApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class EntriesController : GenericController<Logic.Entities.Entry, Models.EditEntry, Models.EntryModel>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataAccess"></param>
        public EntriesController(IDataAccess<Entry> dataAccess) : base(dataAccess)
        {
        }
    }
}
