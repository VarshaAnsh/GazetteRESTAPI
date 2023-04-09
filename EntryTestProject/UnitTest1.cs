using GazetteRESTAPI.Controllers;
using GazetteRESTAPI.Services;
using Microsoft.Extensions.Logging;

namespace EntryTestProject
{
    public class Tests
    {
        private IEntryServices _entryServices;
        [SetUp]
        public void Setup()
        {
            _entryServices= new EntryServices();
        }

        [Test]
        public void Test1()
        {
           var result= _entryServices.GetEntryInformations();
            Assert.AreEqual(result.id, "https://www.thegazette.co.uk/all-notices/notice/data.feed?&results-page=1");
        }
    }
}