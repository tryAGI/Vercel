
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Internal representation of a custom environment with all required properties
    /// </summary>
    public sealed partial class UpdateCustomEnvironmentResponse
    {
        /// <summary>
        /// Configuration for matching git branches to this environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchMatcher")]
        public global::Vercel.UpdateCustomEnvironmentResponseBranchMatcher? BranchMatcher { get; set; }

        /// <summary>
        /// Timestamp when the environment was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// List of aliases for the current deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentDeploymentAliases")]
        public global::System.Collections.Generic.IList<string>? CurrentDeploymentAliases { get; set; }

        /// <summary>
        /// Optional description of the environment's purpose
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of domains associated with this environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateCustomEnvironmentResponseDomain>? Domains { get; set; }

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
        /// The type of environment (production, preview, or development)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateCustomEnvironmentResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateCustomEnvironmentResponseType Type { get; set; }

        /// <summary>
        /// Timestamp when the environment was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomEnvironmentResponse" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Timestamp when the environment was created
        /// </param>
        /// <param name="id">
        /// Unique identifier for the custom environment (format: env_*)
        /// </param>
        /// <param name="slug">
        /// URL-friendly name of the environment
        /// </param>
        /// <param name="type">
        /// The type of environment (production, preview, or development)
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the environment was last updated
        /// </param>
        /// <param name="branchMatcher">
        /// Configuration for matching git branches to this environment
        /// </param>
        /// <param name="currentDeploymentAliases">
        /// List of aliases for the current deployment
        /// </param>
        /// <param name="description">
        /// Optional description of the environment's purpose
        /// </param>
        /// <param name="domains">
        /// List of domains associated with this environment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomEnvironmentResponse(
            double createdAt,
            string id,
            string slug,
            global::Vercel.UpdateCustomEnvironmentResponseType type,
            double updatedAt,
            global::Vercel.UpdateCustomEnvironmentResponseBranchMatcher? branchMatcher,
            global::System.Collections.Generic.IList<string>? currentDeploymentAliases,
            string? description,
            global::System.Collections.Generic.IList<global::Vercel.UpdateCustomEnvironmentResponseDomain>? domains)
        {
            this.BranchMatcher = branchMatcher;
            this.CreatedAt = createdAt;
            this.CurrentDeploymentAliases = currentDeploymentAliases;
            this.Description = description;
            this.Domains = domains;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomEnvironmentResponse" /> class.
        /// </summary>
        public UpdateCustomEnvironmentResponse()
        {
        }

    }
}