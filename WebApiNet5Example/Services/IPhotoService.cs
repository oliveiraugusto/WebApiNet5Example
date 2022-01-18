﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiNet5Example.Models;

namespace WebApiNet5Example.Services
{
    public interface IPhotoService
    {
        Task<Photo> Get();
        Task<Photo> Get(int id);
    }
}