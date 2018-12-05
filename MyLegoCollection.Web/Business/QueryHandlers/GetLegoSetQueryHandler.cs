using System;
using AutoMapper;
using MyLegoCollection.Web.Business.Models;
using MyLegoCollection.Web.Business.Queries;
using MyLegoCollection.Web.Data.Entities;
using Vanguard.Framework.Core.Cqrs;
using Vanguard.Framework.Core.Repositories;

namespace MyLegoCollection.Web.Business.QueryHandlers
{
    public class GetLegoSetQueryHandler : IQueryHandler<LegoSetModel, GetLegoSetQuery>
    {
        private readonly IRepository<LegoSet> _legoSetRepository;
        private readonly IMapper _mapper;

        public GetLegoSetQueryHandler(IRepository<LegoSet> legoSetRepository,IMapper mapper)
        {
            _legoSetRepository = legoSetRepository ?? throw new ArgumentNullException(nameof(legoSetRepository), $"{nameof(legoSetRepository)} is null.");
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper), $"{nameof(mapper)} is null.");
        }

        public LegoSetModel Retrieve(GetLegoSetQuery query)
        {
            LegoSet result = _legoSetRepository.GetById(query.LegoSetId);
            return _mapper.Map<LegoSetModel>(result);
        }
    }
}