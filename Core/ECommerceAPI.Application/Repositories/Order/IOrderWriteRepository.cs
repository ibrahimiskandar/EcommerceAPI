﻿using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    public interface IOrderWriteRepository: IWriteRepository<Order>
    {
    }
}
