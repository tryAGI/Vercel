
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRedirectsResponseVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetRedirectsResponseVariant3Redirect> Redirects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public global::Vercel.GetRedirectsResponseVariant3Version? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRedirectsResponseVariant3Pagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant3" /> class.
        /// </summary>
        /// <param name="redirects"></param>
        /// <param name="pagination"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRedirectsResponseVariant3(
            global::System.Collections.Generic.IList<global::Vercel.GetRedirectsResponseVariant3Redirect> redirects,
            global::Vercel.GetRedirectsResponseVariant3Pagination pagination,
            global::Vercel.GetRedirectsResponseVariant3Version? version)
        {
            this.Redirects = redirects ?? throw new global::System.ArgumentNullException(nameof(redirects));
            this.Version = version;
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant3" /> class.
        /// </summary>
        public GetRedirectsResponseVariant3()
        {
        }
    }
}