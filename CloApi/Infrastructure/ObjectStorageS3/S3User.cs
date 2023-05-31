using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.ObjectStorageS3
{
    public record class S3User
    {
        /// <summary>
        /// Каноническое имя пользователя S3. Уникальное имя пользователя.
        /// </summary>
        [JsonPropertyName("canonical_name")]
        public string? CanonicalName { get; set; }

        /// <summary>
        /// Уникальный идентификатор пользователя S3
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Лимит пользователя по количеству бакетов
        /// </summary>
        [JsonPropertyName("max_buckets")]
        public int? MaxBuckets { get; set; }

        /// <summary>
        /// Имя пользователя S3. Может быть неуникальным.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Массив лимитов пользователя S3
        /// </summary>
        [JsonPropertyName("quotas")]
        public List<S3UserLimits>? Limits { get; set; }

        /// <summary>
        /// Статус пользователя S3
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Уникальный идентификатор тенанта. По умолчанию используется имя проекта.
        /// </summary>
        [JsonPropertyName("tenant")]
        public string? Tenant { get; set; }
    }
}
