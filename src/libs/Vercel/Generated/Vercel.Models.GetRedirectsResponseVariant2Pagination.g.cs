
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRedirectsResponseVariant2Pagination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PerPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numPages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant2Pagination" /> class.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="numPages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRedirectsResponseVariant2Pagination(
            double page,
            double perPage,
            double numPages)
        {
            this.Page = page;
            this.PerPage = perPage;
            this.NumPages = numPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant2Pagination" /> class.
        /// </summary>
        public GetRedirectsResponseVariant2Pagination()
        {
        }
    }
}