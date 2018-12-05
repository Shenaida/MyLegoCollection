using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyLegoCollection.Web.Data.Entities;
using Vanguard.Framework.Core.Cqrs;
using Vanguard.Framework.Core.Repositories;

namespace MyLegoCollection.Web.Business.QueryHandlers
{
    public sealed class GetAllThemesQueryHandler : IQueryHandler<ICollection<ThemeModel>, GetAllThemesQuery>
    {
        private readonly IRepository<Theme> _themeRepository;
        private readonly IMapper _mapper;

        public GetAllThemesQueryHandler(IRepository<Theme> themeRepository, IMapper mapper)
        {
            _themeRepository = themeRepository ?? throw new ArgumentNullException(nameof(themeRepository), $"{nameof(themeRepository)} is null.");
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper), $"{nameof(mapper)} is null.");
        }
        
        public ICollection<ThemeModel> Retrieve(GetAllThemesQuery query)
        {
            IEnumerable<Theme> themes = _themeRepository.Get();
            return _mapper.Map<ICollection<ThemeModel>>(themes);
        }
    }
}
