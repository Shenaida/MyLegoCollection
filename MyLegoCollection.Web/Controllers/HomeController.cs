using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyLegoCollection.Web.Business.Queries;
using MyLegoCollection.Web.Models;
using MyLegoCollection.Web.Models.HomeViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using Vanguard.Framework.Core.Cqrs;

namespace MyLegoCollection.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher, IMapper mapper)
            : base(commandDispatcher, queryDispatcher, mapper)
        {
        }

        public IActionResult Index()
        {
            GetLegoSetCollectionQuery query = new GetLegoSetCollectionQuery();
            ICollection<Business.Models.LegoSetModel> result = QueryDispatcher.Dispatch(query);

            // Return the view
            return View(Mapper.Map<ICollection<LegoSetViewModel>>(result));
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}