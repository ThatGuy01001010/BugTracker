using AutoMapper;
using BugTracker.Domain.Models;
using BugTracker.Services.Models;
using CoderCamps.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BugTracker.Services
{
    public class BugService : ApiController
    {
        private IRepository _repo;

        public BugService(IRepository repo)
        {
            _repo = repo;
        }

        public IList<BugDTO> List()
        {

            return Mapper.Map<List<BugDTO>>((from b in _repo.Query<Bug>()
                                             select b).ToList());
        }

        public void Add(BugDTO bug)
        {
            var dbItem = Mapper.Map<Bug>(bug);
            _repo.Add(dbItem);
            _repo.SaveChanges();
        }

        public BugDTO Find(int id)
        {
            return Mapper.Map<BugDTO>(FindInternal(id));
        }

        private Bug FindInternal(int id)
        {
            return (from m in _repo.Query<Bug>()
                    where m.Id == id
                    select m).FirstOrDefault();
        }

        public void Update(BugDTO bug)
        {
            var dbItem = FindInternal(bug.Id);

            Mapper.Map(bug, dbItem);
            _repo.SaveChanges();
        }
    }
}