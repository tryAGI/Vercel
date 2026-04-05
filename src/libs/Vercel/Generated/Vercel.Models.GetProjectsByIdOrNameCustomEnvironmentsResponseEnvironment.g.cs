
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironment
    {
        /// <summary>
        /// The type of environment (production, preview, or development)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType Type { get; set; }

        /// <summary>
        /// Optional description of the environment's purpose
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Timestamp when the environment was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the environment was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Unique identifier for the custom environment (format: env_*)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// URL-friendly name of the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// List of domains associated with this environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentDomain>? Domains { get; set; }

        /// <summary>
        /// Configuration for matching git branches to this environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchMatcher")]
        public global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcher? BranchMatcher { get; set; }

        /// <summary>
        /// List of aliases for the current deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentDeploymentAliases")]
        public global::System.Collections.Generic.IList<string>? CurrentDeploymentAliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironment" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of environment (production, preview, or development)
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the environment was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the environment was last updated
        /// </param>
        /// <param name="id">
        /// Unique identifier for the custom environment (format: env_*)
        /// </param>
        /// <param name="slug">
        /// URL-friendly name of the environment
        /// </param>
        /// <param name="description">
        /// Optional description of the environment's purpose
        /// </param>
        /// <param name="domains">
        /// List of domains associated with this environment
        /// </param>
        /// <param name="branchMatcher">
        /// Configuration for matching git branches to this environment
        /// </param>
        /// <param name="currentDeploymentAliases">
        /// List of aliases for the current deployment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironment(
            global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType type,
            double createdAt,
            double updatedAt,
            string id,
            string slug,
            string? description,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentDomain>? domains,
            global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcher? branchMatcher,
            global::System.Collections.Generic.IList<string>? currentDeploymentAliases)
        {
            this.Type = type;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Domains = domains;
            this.BranchMatcher = branchMatcher;
            this.CurrentDeploymentAliases = currentDeploymentAliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironment" /> class.
        /// </summary>
        public GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironment()
        {
        }
    }
}