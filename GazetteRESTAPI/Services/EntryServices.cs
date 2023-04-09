using GazetteRESTAPI.Model;
using Newtonsoft.Json;

namespace GazetteRESTAPI.Services
{
    public class EntryServices : IEntryServices
    {
      
        public EntryInformations GetEntryInformations()
        {
            EntryInformations item;
            using (StreamReader r = new StreamReader("data.json"))
            {
                string json = r.ReadToEnd();
                item = JsonConvert.DeserializeObject<EntryInformations>(json);
            }

            return item;
        }
    }
}
