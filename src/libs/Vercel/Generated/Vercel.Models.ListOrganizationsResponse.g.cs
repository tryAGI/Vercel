
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListOrganizationsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.Organization> Organizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationsResponse" /> class.
        /// </summary>
        /// <param name="organizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOrganizationsResponse(
            global::System.Collections.Generic.IList<global::Vercel.Organization> organizations)
        {
            this.Organizations = organizations ?? throw new global::System.ArgumentNullException(nameof(organizations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationsResponse" /> class.
        /// </summary>
        public ListOrganizationsResponse()
        {
        }

    }
}