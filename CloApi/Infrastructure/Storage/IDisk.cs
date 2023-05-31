using CloApi.Infrastructure.Network;
using CloApi.Infrastructure.ServerObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CloApi.Infrastructure.Storage
{
    public interface IDisk
    {
        /// <summary>
        ///  Объект содержащий информацию о сервере, к которому прикреплен диск
        /// </summary>
        [JsonPropertyName("attached_to_server")]
        public Server? AttachedToServer { get; set; }

        /// <summary>
        /// Является ли диск загрузочным
        /// </summary>
        [JsonPropertyName("bootable")]
        public bool? Bootable { get; set; }

        /// <summary>
        /// Дата создания диска
        /// </summary>
        [JsonPropertyName("created_in")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Уникальный идентификатор диска
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Массив ссылок на детальную информацию о диске
        /// </summary>
        [JsonPropertyName("links")]
        public List<Link>? Links { get; set; }

        /// <summary>
        /// Имя диска
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Размер диска в гигабайтах
        /// </summary>
        [JsonPropertyName("size")]
        public int? Size { get; set; }
    }
}
