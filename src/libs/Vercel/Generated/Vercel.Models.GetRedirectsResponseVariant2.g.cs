
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRedirectsResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRedirectsResponseVariant2Version Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetRedirectsResponseVariant2Redirect> Redirects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRedirectsResponseVariant2Pagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant2" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="redirects"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRedirectsResponseVariant2(
            global::Vercel.GetRedirectsResponseVariant2Version version,
            global::System.Collections.Generic.IList<global::Vercel.GetRedirectsResponseVariant2Redirect> redirects,
            global::Vercel.GetRedirectsResponseVariant2Pagination pagination)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Redirects = redirects ?? throw new global::System.ArgumentNullException(nameof(redirects));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant2" /> class.
        /// </summary>
        public GetRedirectsResponseVariant2()
        {
        }
    }
}