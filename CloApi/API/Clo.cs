using CloApi.API.REST;
using CloApi.Infrastructure.AdditionalSoftware;
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
    public class Clo : Rest
    {
        private static readonly string BASEURL = "https://api.clo.ru";

        public Clo(string token)
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        }

        #region ProjectAsyncMethods
        public async Task<List<Project>?> GetProjectsAsync()
        {
            return await GetResultsAsync<Project>($"{BASEURL}/v1/projects");
        }

        public async Task<List<Image>?> GetImagesAsync(string projectId)
        {
            return await GetResultsAsync<Image>($"{BASEURL}/v1/projects/{projectId}/images");
        }

        public async Task<List<ProjectLimit>?> GetLimitsAsync(string projectId)
        {
            return await GetResultsAsync<ProjectLimit>($"{BASEURL}/v1/projects/{projectId}/limits");
        }
        #endregion

        #region RecipeAsyncMethods
        public async Task<List<Recipe>?> GetRecipeAsync()
        {
            return await GetResultsAsync<Recipe>($"{BASEURL}/v1/recipe");
        }
        #endregion

        #region ObjectStorageS3AsyncMethods
        public async Task<List<S3User>?> GetS3UsersAsync(string projectId)
        {
            return await GetResultsAsync<S3User>($"{BASEURL}/v1/projects/{projectId}/s3_users");
        }

        public async Task<S3User> CreateS3UserAsync(string projectId, S3User user)
        {
            return await PostAsync<S3User>($"{BASEURL}/v1/projects/{projectId}/s3_users", user);
        }

        public async Task DeleteS3UserAsync(string userId)
        {
            await DeleteAsync($"{BASEURL}/v1/s3_users/{userId}");
        }

        public async Task<S3User?> GetS3UserAsync(string userId)
        {
            return await GetResultAsync<S3User>($"{BASEURL}/v1/s3_users/{userId}");
        }

        public async Task<Keys?> GetS3UserKeysAsync(string userId)
        {
            return await GetResultAsync<Keys>($"{BASEURL}/v1/s3_users/{userId}/keys");
        }

        public async Task<Keys?> ResetS3UserKeysAsync(string userId)
        {
            return await PostAsync<Keys>($"{BASEURL}/v1/s3_users/{userId}/keys");
        }
        #endregion

       
    }
}
