using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserTask.Module;
using UserTask.Repo;

namespace UserTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public IUsers _users;
        public UsersController(IUsers users)
        {
            _users = users;
        }

        [HttpGet]
        public ActionResult<List<Users>> GetALL()
        {
            return _users.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            var user = _users.Get(id);
            if (user == null)
                return NotFound();
            return user;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var user = _users.Get(id);
            if (user == null)
                return NotFound();
            _users.Delete(id);
            return Ok();
        }
        [HttpPost]
        public ActionResult Create(Users user)
        {

            _users.Add(user);
            return Ok();
           
        }
        [HttpPut]
        public ActionResult Update(Users user)
        {
            var _user = _users.Get(user.Id);
            if (_user == null)
                return NotFound();
            _users.Update(user);
            return Ok();
        }
    }
}
