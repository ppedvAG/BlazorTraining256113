namespace BlazorTraining256113.Components.Pages.Modul4
{
    public class ToDoVM
    {
        public List<Todo> Liste { get; set; }
        public ToDoVM(IHttpClientFactory _http)
        {
                //var cleint = _http.CreateClient();
                //var response = cleint.GetAsync("http://dummyjson.com/todos?limit=300").Result;
                //if (response.IsSuccessStatusCode)
                //{
                //    var result = response.Content.ReadFromJsonAsync<TodoModel>().Result;
                //    Liste = result.todos.ToList();

               var client= _http.CreateClient();
            var response=
                client.GetFromJsonAsync<TodoModel>("https://dummyjson.com/todos?limit=300").Result;
            Liste=response.todos.ToList();

        }
        }
    }

