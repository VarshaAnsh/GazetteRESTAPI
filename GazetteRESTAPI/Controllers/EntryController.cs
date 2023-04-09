using GazetteRESTAPI.Model;
using GazetteRESTAPI.Services;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GazetteRESTAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryController : ControllerBase
    {

        private readonly IEntryServices _entryServices;

        public EntryController(IEntryServices entryServices)
        {
            _entryServices = entryServices;
        }
        [HttpGet(Name = "GetEntryInfo")]
        public ActionResult<EntryInformations> Get()
        {
          return Ok(_entryServices.GetEntryInformations());
        }

    }
}
