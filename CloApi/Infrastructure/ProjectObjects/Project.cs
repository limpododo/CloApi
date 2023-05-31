using System;
using System.Text.Json.Serialization;

namespace CloApi.Infrastructure.ProjectObjects
{
    public record class Project
    {
        /// <summary>
        /// Дата создания проекта
        /// </summary>
        [JsonPropertyName("created_in")]
        public DateTime? DataCreated { get; set; }

        /// <summary>
        /// Наличие неразрешенного тикета за нарушение правил. Если это значение true, то проект может быть остановлен в течение 24 часов
        /// </summary>
        [JsonPropertyName("has_abuse")] 
        public bool? HasAbuse { get; set; }

        /// <summary>
        /// Уникальный идентификатор проекта
        /// </summary>
        [JsonPropertyName("id")] 
        public string? Id { get; set; }

        /// <summary>
        /// Название проекта
        /// </summary>
        [JsonPropertyName("name")] 
        public string? Name { get; set; }

        /// <summary>
        /// Статус проекта
        /// </summary>
        [JsonPropertyName("status")] 
        public string? Status { get; set; }

        /// <summary>
        /// Причина остановки
        /// </summary>
        [JsonPropertyName("stopping_reason")] 
        public string? StoppingReason { get; set; }

        /// <summary>
        /// Общая информация о проекте
        /// </summary>
        [JsonPropertyName("summary")] 
        public Summary? Summary { get; set; }
    }
}
