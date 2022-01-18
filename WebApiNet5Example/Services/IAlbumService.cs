using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiNet5Example.Models;

namespace WebApiNet5Example.Services
{
    public interface IAlbumService
    {
        Task<Album> Get();
        Task<Album> Get(int id);
    }
}
