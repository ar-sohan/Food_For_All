using AutoMapper;
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

        public List<Restaurent> GetAllRestaurents()
        {
            var data = rr.GetAllRestaurents();
            return mapper.Map<List<Restaurent>>(data);
        }

        public Restaurent GetRestaurentById(int id)
        {
            var data = rr.GetRestaurentById(id);
            return mapper.Map<Restaurent>(data);
        }
        public bool CreateRestaurent(Restaurent restaurent)
        {
            var mapped = mapper.Map<Restaurent>(restaurent);
            return rr.CreateRestaurent(mapped);
        }
        public bool DeleteRestaurent(int id)
        {
            return rr.DeleteRestaurent(id);
        }
        public bool UpdateRestaurent(Restaurent restaurent)
        {
            var mapped = mapper.Map<Restaurent>(restaurent);
            return rr.UpdateRestaurent(mapped);
        }
    }
}
