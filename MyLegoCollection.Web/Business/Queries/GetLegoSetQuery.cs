using MyLegoCollection.Web.Business.Models;
using Vanguard.Framework.Core.Cqrs;

namespace MyLegoCollection.Web.Business.Queries
{
    public class GetLegoSetQuery : IQuery<LegoSetModel>
    {
        public int LegoSetId { get; set; }
    }
}