using System.Collections.Generic;
using System.Threading.Tasks;
using turPoeng1.Models;

namespace turPoeng1.Services
{
	public interface IRestService
	{
		Task<List<Person>> RefreshDataAsync();

		//Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

		//Task DeleteTodoItemAsync(string id);
	}
}
