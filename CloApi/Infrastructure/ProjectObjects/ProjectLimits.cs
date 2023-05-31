using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.ProjectObjects
{
    public record class ProjectLimits
    {
        /// <summary>
        /// Верхнее ограничение по использованию ресурса
        /// </summary>
        [JsonPropertyName("max")]
        public int Max { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [JsonPropertyName("measure")]
        public string Measure { get; set; }

        /// <summary>
        /// Наименование ресурса
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Количество использованного ресурса
        /// </summary>
        [JsonPropertyName("used")]
        public int Used { get; set; }
    }
}
