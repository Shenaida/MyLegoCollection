using System.Collections.Generic;
using MyLegoCollection.Web.Business.Models;
using Vanguard.Framework.Core.Cqrs;

namespace MyLegoCollection.Web.Business.Queries
{
    public sealed class GetLegoSetCollectionQuery : IQuery<ICollection<LegoSetModel>>
    {
    }
}