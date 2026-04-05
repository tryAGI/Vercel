
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRoutesResponseVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetRoutesResponseVariant3Route> Routes { get; set; }

        /// <summary>
        /// A version of routing rules stored in S3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRoutesResponseVariant3Version Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant3" /> class.
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="version">
        /// A version of routing rules stored in S3.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutesResponseVariant3(
            global::System.Collections.Generic.IList<global::Vercel.GetRoutesResponseVariant3Route> routes,
            global::Vercel.GetRoutesResponseVariant3Version version)
        {
            this.Routes = routes ?? throw new global::System.ArgumentNullException(nameof(routes));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant3" /> class.
        /// </summary>
        public GetRoutesResponseVariant3()
        {
        }
    }
}