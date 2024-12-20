﻿using DataAccessLayer.Data.Models;
using DataAccessLayer.Repositories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.UserTokenRepo
{
    public interface IUserTokenRepo : IGenericRepo<UserToken>
    {
        Task<UserToken?> GetUserToken(string token); 
    }
}
