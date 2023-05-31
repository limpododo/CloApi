using System.Text.Json.Serialization;

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
