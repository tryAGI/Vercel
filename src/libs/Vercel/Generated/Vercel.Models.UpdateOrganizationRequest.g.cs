
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateOrganizationRequest
    {
        /// <summary>
        /// The hash value of an uploaded image, or `null` to clear the organization avatar. Omit to leave it unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// The new slug for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequest" /> class.
        /// </summary>
        /// <param name="avatar">
        /// The hash value of an uploaded image, or `null` to clear the organization avatar. Omit to leave it unchanged.
        /// </param>
        /// <param name="slug">
        /// The new slug for the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationRequest(
            string? avatar,
            string? slug)
        {
            this.Avatar = avatar;
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequest" /> class.
        /// </summary>
        public UpdateOrganizationRequest()
        {
        }

    }
}