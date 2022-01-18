using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApiNet5Example.Configuration;
using WebApiNet5Example.Models;

namespace WebApiNet5Example.Services
{
    public class TodoService : ITodoService
    {
        private readonly IApiConfig config;
        private readonly HttpClient httpclient;

        public TodoService(IApiConfig config, HttpClient httpclient)
        {
            this.config = config;
            this.httpclient = httpclient;
        }

        public async Task<List<ToDo>> Get()
        {
            return await httpclient.GetFromJsonAsync<List<ToDo>>($"{config.BaseURL}/todos");
        }

        public async Task<ToDo> Get(int id)
        {
            return await httpclient.GetFromJsonAsync<ToDo>($"{config.BaseURL}/todos/{id}");

        }
    }
}
