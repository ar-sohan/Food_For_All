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

        
    }
}
