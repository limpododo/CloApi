using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.ObjectStorageS3
{
    public record class Keys
    {
        /// <summary>
        /// Уникальный идентификатор ключа пользователя S3
        /// </summary>
        [JsonPropertyName("access_key")]
        public string? AccessKey { get; set; }

        /// <summary>
        /// Секретный ключ пользователя S3
        /// </summary>
        [JsonPropertyName("secret_key")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// Уникальный идентификатор пользователя в рамках хранилища S3
        /// </summary>
        [JsonPropertyName("user")]
        public string? UserId { get; set; }

    }
}
