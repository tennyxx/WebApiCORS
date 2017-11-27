using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Filters;

namespace WebApi.Controller
{
    public class MyController : ApiController
    {
        // GET: api/My
        [ActionCORS]
        public MyInfo GetMyInfo()
        {
            var entity = new MyInfo
            {
                Name = "liucx",
                Age = 22,
                Phone = "13011112222",
                Remark = "测试跨域请求"
            };
            return entity;
        }
        public class MyInfo
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Phone { get; set; }
            public string Remark { get; set; }
        }

    }
}
