using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CollectRequestService
    {
        CollectRequestRepo repo;
        IMapper mapper;
        public CollectRequestService(CollectRequestRepo collectRequestRepo, IMapper mapper)
        {
            repo = collectRequestRepo;
            this.mapper = mapper;
        }

        public List<CollectRequestModel> GetAllCollectRequests()
        {
            var collectRequests = repo.GetAllCollectRequests();
            return mapper.Map<List<CollectRequestModel>>(collectRequests);
        }
        public bool AddCollectRequest(CollectRequestModel collectRequestModel)
        {
            var collectRequest = mapper.Map<CollectRequest>(collectRequestModel);
            return repo.AddCollectRequest(collectRequest);
        }

        public bool UpdateCollectRequest(CollectRequestModel collectRequestModel)
        {
            var collectRequest = mapper.Map<CollectRequest>(collectRequestModel);
            return repo.updateCollectRequest(collectRequest);
        }

        public bool UpdateStatus(int id, string status)
        {
            return repo.UpdateStatus(id, status);
        }
    }
}
