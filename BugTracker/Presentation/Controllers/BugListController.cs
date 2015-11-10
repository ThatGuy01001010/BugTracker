using CoderCamps.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BugTracker.Services {
    public class BugListController : ApiController {

        private BugListService _service;
        
        public BugListController(BugListService service) {
            _service = service;
        }


        // GET: api/BugList
        public IEnumerable<BugDTO> Get() {
            return _service.List();
        }


    }
}
