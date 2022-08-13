using System.ComponentModel.DataAnnotations;
using UserTask.Repo;

namespace UserTask.Module
{
    public class Users: BaseModel
    {
     
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public ICollection<Posts> Posts { get; set; }

    }
}
