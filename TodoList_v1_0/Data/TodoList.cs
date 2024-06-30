namespace TodoList_v1_0.Data
{
    public class TodoList
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime TimeOfCreation { get; set; } = DateTime.Now;
        public List<TodoItem>? Items { get; set; } = new List<TodoItem>();
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }

    public class TodoItem
    {
        public int Id { get; set; }
        public string? Item { get; set; }
        public bool IsDone { get; set; }
        public int TodoListId { get; set; }
        public TodoList TodoList { get; set; }


    }
}
