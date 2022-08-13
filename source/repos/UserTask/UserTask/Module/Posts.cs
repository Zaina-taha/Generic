using System.ComponentModel.DataAnnotations.Schema;
using UserTask.Repo;

namespace UserTask.Module
{
    public class Posts: BaseModel
    {

        public string  Title { get; set; }

        [ForeignKey("Id")]
        public int Id { get; set; }
        
        public Users? users { get; set; }


    }
}
