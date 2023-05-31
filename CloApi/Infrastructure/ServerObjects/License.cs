using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.ServerObjects
{
    public class License
    {
        /// <summary>
        /// Тип лицензии. Например ISPmanager или Windows Server
        /// </summary>
        [JsonPropertyName("addon")]
        public string? Addon { get; set; }

        /// <summary>
        /// Наименование лицензии. Необходим для определения конкретной лицензии одного типа, если их несколько.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Количество лицензий. Может потребоваться для ПО с несколькими однотипными лицензиями
        /// </summary>
        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }
}
