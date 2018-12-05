using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyLegoCollection.Web.Business.CommandHandlers;
using MyLegoCollection.Web.Business.Commands;
using MyLegoCollection.Web.Data.Entities;
using Vanguard.Framework.Core.Repositories;
using Vanguard.Framework.Test;
using Xunit;

namespace MyLegoCollection.Web.Test.Business.CommandHandlers
{
    public sealed class AddLegoSetCommandHandlerTest : TestBase<AddLegoSetCommandHandler>
    {
        public AddLegoSetCommandHandlerTest()
        {
            TestInitialize();
        }

        [Fact]
        public void When_ExecuteIsCalled_Should_SaveLegoSet()
        {
            //Arrange
            var command = new AddLegoSetCommand
            {
                Name = "test"
            };

            Mocks<IRepository<LegoSet>>()
                .Setup(repo => repo.Add(It.IsAny<LegoSet>()))
                .Callback<LegoSet>(c=> 
                {
                    c.Name.Should().Be("test");
                });
            Mocks<IRepository<LegoSet>>().Setup(repo => repo.Save()).Returns(1);

            //Act
            SystemUnderTest.Execute(command);

            //Assert is done in callback
        }

        protected override AddLegoSetCommandHandler CreateSystemUnderTest()
        {
            return new AddLegoSetCommandHandler(Mocks<IRepository<LegoSet>>().Object, AutoMapperFixture.CreateMapper());
        }
    }

}
