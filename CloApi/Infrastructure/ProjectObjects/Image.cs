using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.ProjectObjects
{
    public record class Image
    {
        /// <summary>
        /// Уникальный идентификатор образа
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Наименование образа
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Объект операционной системы с параметрами
        /// </summary>
        [JsonPropertyName("operation_system")]
        public OperationSystem? OperationSystem { get; set; }
    }
}
