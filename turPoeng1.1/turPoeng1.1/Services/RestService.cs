using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using turPoeng1.Models;

namespace turPoeng1.Services
{
    public class RestService : IRestService
    {
        HttpClient _client;

        public List<Person> Items { get; private set; }

        public RestService()
        {
            _client = new HttpClient();
          //  _client.MaxResponseContentBufferSize = 256000;
          //  _client.DefaultRequestHeaders.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded' "));
        }
        public async Task<List<Person>> RefreshDataAsync()
        {
            Items = new List<Person>();

            var uri = new Uri(string.Format(Constants.PersonItemsUrl, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<Person>>(content);
                }
                else { Debug.WriteLine(response.StatusCode.ToString()); }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }




        /*
                public  async Task<T> PostResponse (string weburl, string jsonstring) where  T: class
                {
                    var token = App.TokenDatabase.GetToken();

                }
        */
        /*
        public async Task<List<TodoItem>> RefreshDataAsync()
        {
            Items = new List<TodoItem>();

            var uri = new Uri(string.Format(Constants.TodoItemsUrl, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<TodoItem>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }

        public async Task SaveTodoItemAsync(TodoItem item, bool isNewItem = false)
        {
            var uri = new Uri(string.Format(Constants.TodoItemsUrl, string.Empty));

            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    response = await _client.PostAsync(uri, content);
                }
                else
                {
                    response = await _client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tTodoItem successfully saved.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

        public async Task DeleteTodoItemAsync(string id)
        {
            var uri = new Uri(string.Format(Constants.TodoItemsUrl, id));

            try
            {
                var response = await _client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tTodoItem successfully deleted.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }
        */
    }
}
