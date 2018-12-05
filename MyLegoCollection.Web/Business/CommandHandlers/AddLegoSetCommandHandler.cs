using System;
using AutoMapper;
using MyLegoCollection.Web.Business.Commands;
using MyLegoCollection.Web.Data.Entities;
using Vanguard.Framework.Core.Cqrs;
using Vanguard.Framework.Core.Repositories;

namespace MyLegoCollection.Web.Business.CommandHandlers
{
    public sealed class AddLegoSetCommandHandler : ICommandHandler<AddLegoSetCommand>
    {
        private readonly IRepository<LegoSet> _legoSetRepository;
        private readonly IMapper _mapper;

        public AddLegoSetCommandHandler(IRepository<LegoSet> legoSetRepository, IMapper mapper)
        {
            _legoSetRepository = legoSetRepository ?? throw new ArgumentNullException(nameof(legoSetRepository), $"{nameof(legoSetRepository)} is null.");
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper), $"{nameof(mapper)} is null.");
        }

        public void Execute(AddLegoSetCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command), $"{nameof(command)} is null.");
            }

            _legoSetRepository.Add(_mapper.Map<LegoSet>(command));
            _legoSetRepository.Save();
        }
    }
}