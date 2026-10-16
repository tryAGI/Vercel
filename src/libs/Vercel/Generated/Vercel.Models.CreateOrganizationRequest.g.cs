
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationRequest
    {
        /// <summary>
        /// The desired slug for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The desired name for the organization. Generated from the slug if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// The desired slug for the organization.
        /// </param>
        /// <param name="name">
        /// The desired name for the organization. Generated from the slug if not provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationRequest(
            string slug,
            string? name)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationRequest" /> class.
        /// </summary>
        public CreateOrganizationRequest()
        {
        }

    }
}