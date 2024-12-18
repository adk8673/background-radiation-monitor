﻿using InfluxDB.Client;
using RadioUI.Services.Interfaces;

namespace RadioUI.Services
{
    public class InfluxDbService : IInfluxDbService
    {
        // May not be used
        private readonly string _token;

        public InfluxDbService(IConfiguration configuration)
        {
            _token = configuration.GetValue<string>("InfluxDB:Token") ?? string.Empty;
        }

        public async Task<T> QueryAsync<T>(Func<QueryApi, Task<T>> action)
        {
            using (var client = new InfluxDBClient("http://localhost:8086"))
            {
                var query = client.GetQueryApi();
                return await action(query);
            }
        }
    }
}
