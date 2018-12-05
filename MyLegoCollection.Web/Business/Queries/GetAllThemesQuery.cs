using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vanguard.Framework.Core.Cqrs;

namespace MyLegoCollection.Web.Business
{
    public sealed  class GetAllThemesQuery:IQuery<ICollection<ThemeModel>>
    {
    }
}
