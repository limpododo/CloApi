using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.ProjectObjects
{
    public record class Summary
    {
        /// <summary>
        /// Количество используемых плавающих IP адресов
        /// </summary>
        [JsonPropertyName("floating_ips")]
        public int? FloatingIps { get; set; }

        /// <summary>
        /// Количество используемых сетей
        /// </summary>
        [JsonPropertyName("networks")]
        public int? Networks { get; set; }

        /// <summary>
        /// Количество используемых серверов
        /// </summary>
        [JsonPropertyName("servers")]
        public int? Servers { get; set; }

        /// <summary>
        /// Количество используемых дисков
        /// </summary>
        [JsonPropertyName("volumes")]
        public int? Volumes { get; set; }
    }
}
