using InfluxDB.Client;

namespace RadioUI.Services.Interfaces
{
    public interface IInfluxDbService
    {
        Task<T> QueryAsync<T>(Func<QueryApi, Task<T>> action);
    }
}
