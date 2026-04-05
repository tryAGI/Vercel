
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategoryJsonConverter))]
        public global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isArchived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="origin"></param>
        /// <param name="category"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="isArchived"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItem(
            string id,
            string slug,
            string origin,
            global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory? category,
            string? name,
            string? description,
            bool? isArchived,
            double? createdAt,
            double? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Origin = origin ?? throw new global::System.ArgumentNullException(nameof(origin));
            this.Category = category;
            this.Name = name;
            this.Description = description;
            this.IsArchived = isArchived;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItem" /> class.
        /// </summary>
        public CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItem()
        {
        }
    }
}