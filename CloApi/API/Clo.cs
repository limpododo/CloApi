﻿using CloApi.Infrastructure.AdditionalSoftware;
using CloApi.Infrastructure.ObjectStorageS3;
using CloApi.Infrastructure.ProjectObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CloApi.API
{
    public class Clo
    {
        private HttpClient _client;
        public Clo(string token)
        {
            using (_client = new HttpClient())
            {
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            }
        }

        #region ProjectAsyncMethods
        public async Task<List<Project>?> GetProjectsAsync()
        {
            return await GetResultsAsync<Project>("https://api.clo.ru/v1/projects");
        }

        public async Task<List<Image>?> GetImagesAsync(string projectId)
        {
            return await GetResultsAsync<Image>($"https://api.clo.ru/v1/projects/{projectId}/images");
        }

        public async Task<List<ProjectLimit>?> GetLimitsAsync(string projectId)
        {
            return await GetResultsAsync<ProjectLimit>($"https://api.clo.ru/v1/projects/{projectId}/limits");
        }
        #endregion

        #region RecipeAsyncMethods
        public async Task<List<Recipe>?> GetRecipeAsync()
        {
            return await GetResultsAsync<Recipe>($"https://api.clo.ru/v1/recipe");
        }
        #endregion

        #region ObjectStorageS3AsyncMethods
        public async Task<List<S3User>?> GetS3UsersAsync(string projectId)
        {
            return await GetResultsAsync<S3User>($"https://api.clo.ru/v1/projects/{projectId}/s3_users");
        }
        #endregion

        #region GetCloResponse
        private async Task<List<T>> GetResultsAsync<T>(string path)
        {
            using (var message = await _client.GetAsync(path))
            {
                var cloResponse = await message.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CloResponse<T>>(cloResponse)?.Results;
            }
        }

        private async Task<T> GetResultAsync<T>(string path)
        {
            using (var message = await _client.GetAsync(path))
            {
                var cloResponse = await message.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CloResponse<T>>(cloResponse).Result;
            }
        }
        #endregion

        #region PostCloResponse
        private async Task<T> PostParametrsAsync<T>(string path, T obj)
        {
            using (var message = await _client.PostAsync(path, new StringContent(JsonSerializer.Serialize(obj))))
            {
                var cloResponse = await message.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CloResponse<T>>(cloResponse).Result;
            }
        }
        #endregion
    }
}
