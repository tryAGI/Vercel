
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRoutesResponseVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetRoutesResponseVariant4Route> Routes { get; set; }

        /// <summary>
        /// A version of routing rules stored in S3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRoutesResponseVariant4Version Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRoutesResponseVariant4Limit Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant4" /> class.
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="version">
        /// A version of routing rules stored in S3.
        /// </param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutesResponseVariant4(
            global::System.Collections.Generic.IList<global::Vercel.GetRoutesResponseVariant4Route> routes,
            global::Vercel.GetRoutesResponseVariant4Version version,
            global::Vercel.GetRoutesResponseVariant4Limit limit)
        {
            this.Routes = routes ?? throw new global::System.ArgumentNullException(nameof(routes));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Limit = limit ?? throw new global::System.ArgumentNullException(nameof(limit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant4" /> class.
        /// </summary>
        public GetRoutesResponseVariant4()
        {
        }
    }
}