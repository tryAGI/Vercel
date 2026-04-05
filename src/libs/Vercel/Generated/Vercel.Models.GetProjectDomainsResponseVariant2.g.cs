
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectDomainsResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectDomainsResponseVariant2Domain> Domains { get; set; }

        /// <summary>
        /// This object contains information related to the pagination of the current request, including the necessary parameters to get the next or previous page of data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Pagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDomainsResponseVariant2" /> class.
        /// </summary>
        /// <param name="domains"></param>
        /// <param name="pagination">
        /// This object contains information related to the pagination of the current request, including the necessary parameters to get the next or previous page of data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectDomainsResponseVariant2(
            global::System.Collections.Generic.IList<global::Vercel.GetProjectDomainsResponseVariant2Domain> domains,
            global::Vercel.Pagination pagination)
        {
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDomainsResponseVariant2" /> class.
        /// </summary>
        public GetProjectDomainsResponseVariant2()
        {
        }
    }
}