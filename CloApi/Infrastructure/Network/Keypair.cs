using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.Network
{
    public record class Keypair
    {
        /// <summary>
        /// Уникальный идентификатор SSH-ключа
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Имя SSH-ключа
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Значение публичного ключа
        /// </summary>
        [JsonPropertyName("public_key")]
        public string? PublicKey { get; set; }
    }
}
