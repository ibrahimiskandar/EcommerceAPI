﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Features.Commands.User.RegisterUser
{
    public class RegisterUserCommandResponse
    {
        public bool IsSucceeded { get; set; }
        public string Message { get; set; }
    }
}
