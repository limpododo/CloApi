using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using CloApi.Infrastructure.Network;
using CloApi.Infrastructure.ServerObjects;

namespace CloApi.Infrastructure.AdditionalSoftware
{
    public record class Snapshot
    {
        /// <summary>
        /// Список дочерних серверов
        /// </summary>
        [JsonPropertyName("child_servers")]
        public List<Server> ChildServers { get; set; }

        /// <summary>
        /// Дата создания снапшота
        /// </summary>
        [JsonPropertyName("created_in")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Время, в которое снапшот будет удалён
        /// </summary>
        [JsonPropertyName("deleted_in")]
        public DateTime DateDeleted { get; set; }

        /// <summary>
        /// Уникальный идентификатор снапшота
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Список ссылок на детальную информацию о снапшоте
        /// </summary>
        [JsonPropertyName("links")]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Название снапшота
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Объект, содержащий информацию о сервере, с которого был сделан снапшот
        /// </summary>
        [JsonPropertyName("parent_server")]
        public Server ParentServer { get; set; }

        /// <summary>
        /// Размер снапшота в гигабайтах
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }

        /// <summary>
        /// Статус снапшота
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
