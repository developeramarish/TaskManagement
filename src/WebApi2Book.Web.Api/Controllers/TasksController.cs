using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi2Book.Web.Api.Controllers
{
    [RoutePrefixAttribute("api/employeeTasks")]
    public class TasksController : ApiController
    {
        [Route("{id:int:max(100)}")]
        public string GetTaskWithAMaxIdOf100(int id)
        {
            return "In the GetTaskWithAMaxIdOf100(int id) method, id = " + id;
        }

        [Route("{id:int:min(101)}")]
        [HttpGet]
        public string FindTasksWithAMinIdOf101(int id)
        {
            return "In the FindTasksWithAMinIdOf101(int id) method, id = " + id;
        }

        public string Get(string taskNum)
        {
            return "In the Get(string taskNum) method, taskNum = " + taskNum;
        }
    }
}
