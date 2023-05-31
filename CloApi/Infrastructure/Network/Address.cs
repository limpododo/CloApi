using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.Network
{
    public record class Address
    {
        /// <summary>
        /// При установке флага вы получите защищенный от DDoS-атак IP
        /// </summary>
        [JsonPropertyName("ddos_protection")]
        public bool? DdosProtection { get; set; }

        /// <summary>
        /// При значении true создаст сервер со статическим IP-адресом
        /// </summary>
        [JsonPropertyName("external")] 
        public bool? IsExternal { get; set; }

        /// <summary>
        /// Если в проекте уже есть плавающий IP, то, передав ID этого IP, его можно подключить на этапе создания
        /// </summary>
        [JsonPropertyName("floatingip_id")]
        public string? FloatingIPID { get; set; }

        /// <summary>
        /// MAC-адрес интерфейса
        /// </summary>
        [JsonPropertyName("mac_addr")] 
        public string? MacAddr { get; set; }

        /// <summary>
        /// Имя IP-адреса
        /// </summary>
        [JsonPropertyName("name")] 
        public string? Name { get; set; }

        /// <summary>
        /// Значение PTR-записи IP-адреса
        /// </summary>
        [JsonPropertyName("ptr")] 
        public string? Ptr { get; set; }

        /// <summary>
        /// Тип IP-адреса
        /// </summary>
        [JsonPropertyName("type")] 
        public string? Type { get; set; }

        /// <summary>
        /// Версия IP. Либо 4, Либо 6
        /// </summary>
        [JsonPropertyName("version")] 
        public int? Version { get; set; }
    }
}
