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

        public bool AddCollectRequest(CollectRequestModel collectRequestModel)
        {
            var collectRequest = mapper.Map<CollectRequest>(collectRequestModel);
            return repo.AddCollectRequest(collectRequest);
        }

    }
}
