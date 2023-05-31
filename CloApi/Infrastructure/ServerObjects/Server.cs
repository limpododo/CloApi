using CloApi.Infrastructure.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloApi.Infrastructure.ServerObjects
{
    public record class Server
    {
        /// <summary>
        /// Дата создания сервера
        /// </summary>
        [JsonPropertyName("created_in")]
        public DateTime? DataCreated { get; set; }

        /// <summary>
        /// Имя сервера
        /// </summary>
        [JsonPropertyName("name")] 
        public string? Name { get; set; }

        /// <summary>
        /// Список дисков, которые подключены к серверу
        /// </summary>
        [JsonPropertyName("disk_data")] 
        public List<DiskInfo>? DisksInfo { get; set; }

        /// <summary>
        /// Уникальный идентификатор проекта-родителя
        /// </summary>
        [JsonPropertyName("project_id")] 
        public string? OwnerProjectId { get; set; }

        /// <summary>
        /// Статус сервера
        /// </summary>
        [JsonPropertyName("status")] 
        public string? Status { get; set; }

        /// <summary>
        /// Уникальный идентификатор сервера
        /// </summary>
        [JsonPropertyName("id")] 
        public string? Id { get; set; }

        /// <summary>
        /// Образ операционной системы, используемый для создания сервера
        /// </summary>
        [JsonPropertyName("image")] 
        public string? Image { get; set; }

        /// <summary>
        /// Список ссылок на детальную информацию о диске
        /// </summary>
        [JsonPropertyName("links")] 
        public List<Link>? Links { get; set; }

        /// <summary>
        /// Массив IP-адресов сервера
        /// </summary>
        [JsonPropertyName("addresses")] 
        public List<Address>? Addresses { get; set; }

        /// <summary>
        /// Объект, содержащий параметры о вычислительных ресурсах сервера
        /// </summary>
        [JsonPropertyName("flavor")] 
        public Flavor? Flavor { get; set; }

        /// <summary>
        /// Находится ли сервер в режиме восстановления
        /// </summary>
        [JsonPropertyName("in_rescue")] 
        public bool? InRescue { get; set; }

        /// <summary>
        /// Рецепт доп. ПО, используемый для создания сервера
        /// </summary>
        [JsonPropertyName("recipe")] 
        public string? Recipe { get; set; }
    }
}
