using QTDictionaryAuth.Logic;
using QTDictionaryAuth.Logic.Entities;

namespace QTDictionaryAuth.AspMvc.Controllers
{
    public class EntriesController : GenericController<Logic.Entities.Entry, Models.EntryModel>
    {
        public EntriesController(IDataAccess<Entry> dataAccess) : base(dataAccess)
        {
        }


    }
}
