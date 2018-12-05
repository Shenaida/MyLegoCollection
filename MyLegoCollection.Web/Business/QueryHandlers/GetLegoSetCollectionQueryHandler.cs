using System;
using System.Collections.Generic;
using AutoMapper;
using MyLegoCollection.Web.Business.Models;
using MyLegoCollection.Web.Business.Queries;
using MyLegoCollection.Web.Data.Entities;
using Vanguard.Framework.Core.Cqrs;
using Vanguard.Framework.Core.Repositories;

namespace MyLegoCollection.Web.Business.QueryHandlers
{
    public class GetLegoSetCollectionQueryHandler : IQueryHandler<ICollection<LegoSetModel>, GetLegoSetCollectionQuery>
    {
        private readonly IRepository<LegoSet> _legoSetRepository;
        private readonly IMapper _mapper;

        public GetLegoSetCollectionQueryHandler(IRepository<LegoSet> legoSetRepository, IMapper mapper)
        {
            _legoSetRepository = legoSetRepository ?? throw new ArgumentNullException(nameof(legoSetRepository), $"{nameof(legoSetRepository)} is null.");
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper), $"{nameof(mapper)} is null.");
        }

        public ICollection<LegoSetModel> Retrieve(GetLegoSetCollectionQuery query)
        {
            IEnumerable<LegoSet> result = _legoSetRepository.Get();

            return _mapper.Map<ICollection<LegoSetModel>>(result);
        }
    }
}