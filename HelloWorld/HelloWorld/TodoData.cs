using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    // this line was added to test git
    class TodoData
    {
        private const string Url = "http://192.168.1.154:5000/api/todoes/";
        private HttpClient client = new HttpClient();

        public async Task<List<Models.Todo>> GetResult()
        {
            try
            {
                var json = await client.GetStringAsync(Url);
                return JsonConvert.DeserializeObject<List<Models.Todo>>(json.ToString());
            }
            catch (System.Exception e)
            {
                return null;
            }
        }
    }
}
