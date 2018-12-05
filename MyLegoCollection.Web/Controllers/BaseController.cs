using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vanguard.Framework.Core.Cqrs;

namespace MyLegoCollection.Web.Controllers
{
    public class BaseController : Controller
    {
        protected ICommandDispatcher CommandDispatcher { get; }
        protected IQueryDispatcher QueryDispatcher { get; }
        protected IMapper Mapper { get; }

        protected BaseController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher, IMapper mapper)
        {
            CommandDispatcher = commandDispatcher ?? throw new ArgumentNullException(nameof(commandDispatcher), $"{nameof(commandDispatcher)} is null.");
            QueryDispatcher = queryDispatcher ?? throw new ArgumentNullException(nameof(queryDispatcher), $"{nameof(queryDispatcher)} is null.");
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper), $"{nameof(mapper)} is null.");
        }
    }
}

