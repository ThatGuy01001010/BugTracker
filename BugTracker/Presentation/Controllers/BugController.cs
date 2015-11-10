using BugTracker.Services;
using BugTracker.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BugTracker.Presentation.Controllers
{
    public class BugController : ApiController
    {
        private BugService _service;

        public BugController(BugService service)
        {
            _service = service;
        }

        public IEnumerable<BugDTO> Get()
        {
            var bugs = _service.List();
            return bugs;
        }


        public HttpResponseMessage Post(BugDTO bug)
        {
            if (ModelState.IsValid)
            {
                if (bug.Id > 0)
                {
                    _service.Update(bug);
                }
                else
                {
                    _service.Add(bug);
                }
                return Request.CreateResponse(HttpStatusCode.OK, bug);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }
    }
}