using CoderCamps.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Services {
    public class BugListService {

        private IRepository _repo;

        public BugListService(IRepository repo) {
            _repo = repo;
        }

        public IEnumerable<BugDTO> List() {
            return AutoMapper.Mapper<List<BugDTO>>(_repo.Query<Bug>().ToList());
        }

        public BugDTO Find(int id) {
            return.Mapper.Map<BugDTO>(_repo.Find<Bug>(id));
        }
    }

}