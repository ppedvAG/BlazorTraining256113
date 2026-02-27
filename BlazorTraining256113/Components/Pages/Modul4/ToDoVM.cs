namespace BlazorTraining256113.Components.Pages.Modul4
{
    public class ToDoVM
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public List<Todo> Liste { get; private set; } = [];

        public ToDoVM(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task LoadTodosAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetFromJsonAsync<TodoModel>("https://dummyjson.com/todos?limit=300");
            Liste = response?.todos?.ToList() ?? [];
        }
    }
}
