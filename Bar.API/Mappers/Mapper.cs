﻿using AutoMapper;
using Bar.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bar.API.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<ItemOrder, ItemOrder>();
            CreateMap<Order, Order>();
        }
    }
}