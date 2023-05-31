using System.Text.Json.Serialization;

namespace CloApi.Infrastructure.Network
{
    public record class Link
    {
        /// <summary>
        /// Ссылка
        /// </summary>
        [JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// Версия API
        /// </summary>
        [JsonPropertyName("rel")] 
        public string? ApiVersion { get; set; }
    }
}
