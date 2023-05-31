using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.ObjectStorageS3
{
    public record class S3UserLimits
    {
        /// <summary>
        /// Максимально допустимое количество объектов
        /// </summary>
        [JsonPropertyName("max_objects")]
        public int? MaxObjects { get; set; }

        /// <summary>
        /// Максимально допустимый объем данных в Кб
        /// </summary>
        [JsonPropertyName("max_size")]
        public int? MaxSize{ get; set; }

        /// <summary>
        /// Тип лимита пользователя - для каждого бакета, либо общая для пользователя S3
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
