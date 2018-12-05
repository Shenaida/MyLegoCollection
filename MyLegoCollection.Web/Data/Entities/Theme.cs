using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vanguard.Framework.Core.Repositories;

namespace MyLegoCollection.Web.Data.Entities
{
    public class Theme: IDataEntity
    {

        /// <summary>
        /// Gets or sets the name of the theme.
        /// </summary>
        /// <value>
        /// The names of Lego theme.
        /// </value>
        public int Id { get; set; }
        public string Name { get; set; }


        //public string LegoArchitecture { get; set; }
        //public string LegoAgentsModels { get; set; }
        //public string LegoAngryBirds { get; set; }
        //public string LegoTheLegoBatmanMovie { get; set; }
        //public string LegoBoost { get; set; }
        //public string LegoBrickHeadz { get; set; }
        //public string LegoCars { get; set; }
        //public string LegoCity { get; set; }
        //public string LegoClassic { get; set; }
        //public string LegoCreator { get; set; }
        //public string LegoDCSuperHeroGirls { get; set; }
        //public string LegoDisneyPrincess { get; set; }
        //public string LegoDuplo { get; set; }
        //public string LegoElves { get; set; }
        //public string LegoFriends { get; set; }
        //public string LegoGhostbusters { get; set; }
        //public string LegoIdeas { get; set; }
        //public string LegoJuniors { get; set; }
        //public string LegoJurassicWorld { get; set; }
        //public string LegoMindstorms { get; set; }
        //public string LegoNinjago { get; set; }
        //public string LegoStarWars { get; set; }
        //public string MyProperty { get; set; }
    }
}
