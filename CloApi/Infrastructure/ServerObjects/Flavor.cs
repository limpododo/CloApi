using System.Text.Json.Serialization;

namespace CloApi.Infrastructure.ServerObjects
{
    public record class Flavor
    {
        /// <summary>
        /// Количество RAM
        /// </summary>
        [JsonPropertyName("ram")]
        public int? Ram { get; set; }

        /// <summary>
        /// Количество vCPU
        /// </summary>
        [JsonPropertyName("vcpus")]
        public int? VCPUs { get; set; }
    }
}
