using AutoMapper;
using FluentAssertions;
using Moq;
using MyLegoCollection.Web.Business.Models;
using MyLegoCollection.Web.Business.Queries;
using MyLegoCollection.Web.Business.QueryHandlers;
using MyLegoCollection.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vanguard.Framework.Core.Repositories;
using Vanguard.Framework.Test;
using Xunit;

namespace MyLegoCollection.Web.Test.Business.QueryHandlers
{
    public sealed class GetLegoSetCollectionQueryHandlerTest : TestBase<GetLegoSetCollectionQueryHandler>, IDisposable
    {
        private readonly IMapper _mapper;

        public GetLegoSetCollectionQueryHandlerTest()
        {
            TestInitialize();
            _mapper = AutoMapperFixture.CreateMapper();
        }

        public void Dispose()
        {
            MockRepository.VerifyAll();
        }

        ICollection<LegoSetModel> GetLegoSetModels()
        {
            return _mapper.Map<ICollection<LegoSetModel>>(GetLegoSets());
        }

        [Fact]
        void When_Retrieve_IsCalled_Should_Return_LegoSetCollection()
        {
            //Arrange
            ICollection<LegoSetModel> legoSetModels = GetLegoSetModels();
            GetLegoSetCollectionQuery query = new GetLegoSetCollectionQuery();

            //Act
            ICollection<LegoSetModel> result = SystemUnderTest.Retrieve(query);

            //Assert
            result.Should().NotBeNull("because we expect a result");
            result.Count().Should().Be(legoSetModels.Count(), $"because we expect {legoSetModels.Count()} Lego sets");
            result.Should().BeEquivalentTo(legoSetModels);
        }

        protected override GetLegoSetCollectionQueryHandler CreateSystemUnderTest()
        {
            List<LegoSet> legoSets = GetLegoSets();

            var repository = Mocks<IRepository<LegoSet>>();
            repository.Setup(repo => repo.Get(null, null, new string[0])).Returns(legoSets);

            return new GetLegoSetCollectionQueryHandler(repository.Object, _mapper);
        }

        private static List<LegoSet> GetLegoSets()
        {
            return new List<LegoSet>
            {
                new LegoSet
                {
                    SetId = 1,
                    Name = "test 1"
                }
            };
        }
    }
}
