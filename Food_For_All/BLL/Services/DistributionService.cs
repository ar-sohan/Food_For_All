using AutoMapper;
using BLL.Models;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class DistributionService
    {
        DistributionRepo repo;
        IMapper mapper;
        public DistributionService(DistributionRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public List<DistributionModel> GetAllDistributions()
        {
            var data = repo.GetAllDistributions();
            return mapper.Map<List<DistributionModel>>(data);
        }

        public DistributionModel GetDistributionById(int id)
        {
            var data = repo.GetDistributionById(id);
            return mapper.Map<DistributionModel>(data);
        }

        public bool AddDistribution(DistributionModel distributionModel)
        {
            var data = mapper.Map<DAL.EF.Tables.Distribution>(distributionModel);
            return repo.AddDistribution(data);
        }

    }
}
