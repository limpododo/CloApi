using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CloApi.API.REST
{
    public class Rest
    {
        protected HttpClient _client = new HttpClient();

        #region Get
        protected async Task<List<T>> GetResultsAsync<T>(string path)
        {
            using (var message = await _client.GetAsync(path))
            {
                var cloResponse = await message.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CloResponse<T>>(cloResponse)?.Results;
            }
        }

        protected async Task<T> GetResultAsync<T>(string path)
        {
            using (var message = await _client.GetAsync(path))
            {
                var cloResponse = await message.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CloResponse<T>>(cloResponse).Result;
            }
        }
        #endregion

        #region Post
        protected async Task<T> PostAsync<T>(string path, T obj)
        {
            using (var message = await _client.PostAsync(path, new StringContent(JsonSerializer.Serialize(obj))))
            {
                var cloResponse = await message.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CloResponse<T>>(cloResponse).Result;
            }
        }

        protected async Task<T> PostAsync<T>(string path)
        {
            using (var message = await _client.PutAsync(path, null))
            {
                var cloResponse = await message.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CloResponse<T>>(cloResponse).Result;
            }
        }
        #endregion

        #region Delete
        protected async Task DeleteAsync(string path)
        {
            await _client.DeleteAsync(path);
        }
        #endregion
    }
}
