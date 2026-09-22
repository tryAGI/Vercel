
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRedirectsResponseVariant3Pagination
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numPages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumPages { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant3Pagination" /> class.
        /// </summary>
        /// <param name="numPages"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRedirectsResponseVariant3Pagination(
            double numPages,
            double page,
            double perPage)
        {
            this.NumPages = numPages;
            this.Page = page;
            this.PerPage = perPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant3Pagination" /> class.
        /// </summary>
        public GetRedirectsResponseVariant3Pagination()
        {
        }

    }
}