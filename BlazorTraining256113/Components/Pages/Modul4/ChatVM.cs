namespace BlazorTraining256113.Components.Pages.Modul4
{
    public class ChatVM
    {
        public List<ChatModel> Liste { get; set; } = new();
        public event Action OnAdd;
        public void AddMessage(string message)
        {
            Liste.Add(new ChatModel { Message = message });
            OnAdd?.Invoke();
        }
    }
}
