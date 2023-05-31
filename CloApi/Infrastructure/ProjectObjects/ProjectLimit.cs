using System.Text.Json.Serialization;

namespace CloApi.Infrastructure.ProjectObjects
{
    public record class ProjectLimit
    {
        /// <summary>
        /// Верхнее ограничение по использованию ресурса
        /// </summary>
        [JsonPropertyName("max")]
        public int? Max { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [JsonPropertyName("measure")]
        public string? Measure { get; set; }

        /// <summary>
        /// Наименование ресурса
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Количество использованного ресурса
        /// </summary>
        [JsonPropertyName("used")]
        public int? Used { get; set; }
    }
}
