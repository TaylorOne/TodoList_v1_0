using Microsoft.AspNetCore.Identity;

namespace TodoList_v1_0.Data
{
    public class ApplicationUser : IdentityUser
    {
        List<TodoList> TodoLists { get; set; }
    }
}
