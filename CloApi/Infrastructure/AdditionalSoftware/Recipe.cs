using CloApi.Infrastructure.ProjectObjects;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace CloApi.Infrastructure.AdditionalSoftware
{
    public record class Recipe
    {
        /// <summary>
        /// Уникальный идентификатор рецепта
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Минимально допустимый объём диска для установки рецепта
        /// </summary>
        [JsonPropertyName("min_disk")]
        public int? MinDisk { get; set; }

        /// <summary>
        /// Минимально допустимое количество RAM для установки рецепта
        /// </summary>
        [JsonPropertyName("min_ram")]
        public int? MinRam { get; set; }

        /// <summary>
        /// Минимально допустимое количество vCPU для установки рецепта
        /// </summary>
        [JsonPropertyName("min_vcpus")]
        public int? MinVCPUs { get; set; }

        /// <summary>
        /// Наименование рецепта
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Список, содержащий объекты образов ОС, с которыми возможна установка рецепта
        /// </summary>
        [JsonPropertyName("suitable_images")]
        public List<Image>? SuitableImages { get; set; }

    }
}
