using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.ProjectObjects
{
    public record class OperationSystem
    {
        /// <summary>
        /// Версия операционной системы
        /// </summary>
        [JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Название дистрибутива
        /// </summary>
        [JsonPropertyName("distribution")]
        public string? Distribution { get; set; }

        /// <summary>
        /// Семейство операционных систем
        /// </summary>
        [JsonPropertyName("os_family")]
        public string? OsFamily { get; set; }
    }
}
