using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using turPoeng1.Models;

namespace turPoeng1.Services
{
    public class PersonManager
    {
        IRestService restService;

        public PersonManager(IRestService service)
        {
            restService = service;
        }
        public Task<List<Person>> GetTasksAsync()
        {
            return restService.RefreshDataAsync();
        }
    }
}
