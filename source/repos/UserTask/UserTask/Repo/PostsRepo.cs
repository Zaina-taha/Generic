using Microsoft.EntityFrameworkCore;
using UserTask.Module;

namespace UserTask.Repo
{
    public class PostsRepo :GenRepo<Posts>, IPosts
    {
        public PostsRepo(UsersContext context) : base(context)
        {

        }

        //public new List<Posts>? GetAll()
        //{
        //    return _context.Posts.Include(c => c.users).ToList();
        //}

    }
}
