using Microsoft.AspNetCore.Mvc;
using MyLegoCollection.Web.Models.CollectionViewModels;
using Vanguard.Framework.Core.Cqrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using AutoMapper;
using MyLegoCollection.Web.Business.Commands;
using MyLegoCollection.Web.Business;

namespace MyLegoCollection.Web.Controllers
{
    public class CollectionController : BaseController
    {
        public CollectionController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher, IMapper mapper) 
            : base(commandDispatcher, queryDispatcher, mapper)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new AddLegoSetViewModel();
            var query = new GetAllThemesQuery();
            var themes = QueryDispatcher.Dispatch(query);
            model.Themes = new List<Data.Entities.Theme>();//todo:change to dto
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(AddLegoSetViewModel legoSet)
        {
            if(ModelState.IsValid)
            {
                CommandDispatcher.Dispatch(Mapper.Map<AddLegoSetCommand>(legoSet));
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


        public IActionResult BatchAdd()
        {
            return View();
        }

        public IActionResult VerifySetNumbers(BatchAddModel model)
        {
            if (ModelState.IsValid)
            {
                //todo: refactor de onderstaande code naar de business laag. Denk na over wat het doet. Als je niet uit de code
                // kan halen wat het precies doet, zet breakpoint en step er doorheen.
                string patternToMatchWholeNumbers = "[0-9]+";
                MatchCollection collection = Regex.Matches(model.SetNumbers, patternToMatchWholeNumbers);
                ICollection<int> setNumbers = collection.Select(match => int.Parse(match.Value)).ToList();
                //------------------------------------------------

                //var result = _verification.Verify(setNumbers);

                return View();
            }
            //todo: nadenken over wat er moet gebeuren als de modelstate niet valid is

            throw new NotSupportedException();
        }
    }
}