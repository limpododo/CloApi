using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
