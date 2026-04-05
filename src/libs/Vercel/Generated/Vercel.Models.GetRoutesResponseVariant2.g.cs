
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRoutesResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetRoutesResponseVariant2Route> Routes { get; set; }

        /// <summary>
        /// A version of routing rules stored in S3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRoutesResponseVariant2Version Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diffCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DiffCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant2" /> class.
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="version">
        /// A version of routing rules stored in S3.
        /// </param>
        /// <param name="diffCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutesResponseVariant2(
            global::System.Collections.Generic.IList<global::Vercel.GetRoutesResponseVariant2Route> routes,
            global::Vercel.GetRoutesResponseVariant2Version version,
            double diffCount)
        {
            this.Routes = routes ?? throw new global::System.ArgumentNullException(nameof(routes));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.DiffCount = diffCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant2" /> class.
        /// </summary>
        public GetRoutesResponseVariant2()
        {
        }
    }
}