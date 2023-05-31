using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.Network
{
    public class Link
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
