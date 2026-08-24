using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class RestaurentService
    {
        RestaurentRepo rr;
        IMapper mapper;
        public RestaurentService(RestaurentRepo rr, IMapper mapper)
        {
            this.rr = rr;
            this.mapper = mapper;
        }

        public List<RestaurentModel> GetAllRestaurents()
        {
            var restaurents = rr.GetAllRestaurents();
            return mapper.Map<List<RestaurentModel>>(restaurents);
        }

        public RestaurentModel GetRestaurentById(int id)
        {
            var restaurent = rr.GetRestaurentById(id);
            return mapper.Map<RestaurentModel>(restaurent);
        }

        public bool AddRestaurent(RestaurentModel restaurentModel)
        {
            var restaurent = mapper.Map<Restaurent>(restaurentModel);
            return rr.AddRestaurent(restaurent);
        }
    }
}
