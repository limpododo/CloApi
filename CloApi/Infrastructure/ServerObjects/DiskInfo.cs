using CloApi.Infrastructure.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.ServerObjects
{
    public record class DiskInfo
    {
        /// <summary>
        /// Уникальный идентификатор диска
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Тип диска. volume - для сетевых дисков, local - для локальных
        /// </summary>
        [JsonPropertyName("storage_type")]
        public string? StorageType { get; set; }

        /// <summary>
        /// Список ссылок на детальную информацию о диске
        /// </summary>
        [JsonPropertyName("links")]
        public List<Link>? Links { get; set; }
    }
}
