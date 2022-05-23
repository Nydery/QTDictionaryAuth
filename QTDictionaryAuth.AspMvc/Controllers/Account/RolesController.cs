//@CodeCopy
//MdStart
#if ACCOUNT_ON
using QTDictionaryAuth.Logic;

namespace QTDictionaryAuth.AspMvc.Controllers.Account
{
    public class RolesController : GenericController<Logic.Entities.Account.Role, Models.Account.Role>
    {
        public RolesController(IDataAccess<Logic.Entities.Account.Role> dataAccess) : base(dataAccess)
        {
        }
    }
}
#endif
//MdEnd
