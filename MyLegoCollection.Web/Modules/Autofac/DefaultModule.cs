using System.Linq;
using Autofac;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyLegoCollection.Web.Data;
using Vanguard.Framework.Core.Cqrs;
using Vanguard.Framework.Data.Repositories;

namespace MyLegoCollection.Web.Modules.Autofac
{
    public sealed class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CommandDispatcher>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<QueryDispatcher>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<Mapper>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterGeneric(typeof(Repository<>)).AsImplementedInterfaces();
            builder.RegisterType<ApplicationDbContext>().As<DbContext>();

            //

            var businessLayer = GetType().Assembly;
            builder.RegisterAssemblyTypes(businessLayer)
                .Where(type => type.Name.EndsWith("CommandHandler"))
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(businessLayer)
                .Where(type => type.Name.EndsWith("QueryHandler"))
                .AsImplementedInterfaces();
        }
    }
}