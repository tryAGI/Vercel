
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDomainProjectDomainsResponse
    {
        /// <summary>
        /// This object contains information related to the pagination of the current request, including the necessary parameters to get the next or previous page of data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Pagination Pagination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDomains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetDomainProjectDomainsResponseProjectDomain> ProjectDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainProjectDomainsResponse" /> class.
        /// </summary>
        /// <param name="pagination">
        /// This object contains information related to the pagination of the current request, including the necessary parameters to get the next or previous page of data.
        /// </param>
        /// <param name="projectDomains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDomainProjectDomainsResponse(
            global::Vercel.Pagination pagination,
            global::System.Collections.Generic.IList<global::Vercel.GetDomainProjectDomainsResponseProjectDomain> projectDomains)
        {
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.ProjectDomains = projectDomains ?? throw new global::System.ArgumentNullException(nameof(projectDomains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainProjectDomainsResponse" /> class.
        /// </summary>
        public GetDomainProjectDomainsResponse()
        {
        }

    }
}