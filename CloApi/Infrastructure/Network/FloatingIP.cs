using CloApi.Infrastructure.ServerObjects;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CloApi.Infrastructure.Network
{
    public record class FloatingIP
    {
        /// <summary>
        /// Информация о сервере, к которому подключен плавающий IP
        /// </summary>
        [JsonPropertyName("attached_to_server")]
        public Server? AttachedToServer { get; set; }

        /// <summary>
        /// Дата создания адреса
        /// </summary>
        [JsonPropertyName("created_in")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Защита от DDoS-атак
        /// </summary>
        [JsonPropertyName("ddos_protection")]
        public bool? DdosProtection { get; set; }

        /// <summary>
        /// IP адрес в серой сети, к которому подключен плавающий IP
        /// </summary>
        [JsonPropertyName("fixed_ip_address")]
        public string? FixedIpAddress { get; set; }

        /// <summary>
        /// IP адрес
        /// </summary>
        [JsonPropertyName("floating_ip_address")]
        public string? FloatingIpAddress { get; set; }

        /// <summary>
        /// Уникальный идентификатор адреса
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Массив ссылок на детальную информацию о плавающем IP
        /// </summary>
        [JsonPropertyName("links")]
        public List<Link>? Links { get; set; }

        /// <summary>
        /// Значение PTR-записи
        /// </summary>
        [JsonPropertyName("ptr")]
        public string? Ptr { get; set; }

        /// <summary>
        /// Статус IP адреса
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Время последнего обновления элемента
        /// </summary>
        [JsonPropertyName("updated_in")]
        public DateTime? DateUpdated { get; set; }
    }
}
