using Flowing.Application.Interfaces;
using System.Web.Http;

namespace Flowing.API.Controllers
{
    public class ValuesController : ApiController
    {  
       private readonly IUserApplicationService _clienteApp;

       public ValuesController(IUserApplicationService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        public string Get()
        {
            _clienteApp.GetSomeUsers();
            return "value";
        }
        

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
