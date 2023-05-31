using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.API
{
    public class CloResponse<T>
    {
        [JsonPropertyName("code")]
        public int? Code { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("results")]
        public List<T>? Results { get; set; }

        [JsonPropertyName("result")]
        public T? Result { get; set; }
    }
}
