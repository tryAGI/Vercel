
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2Images
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizes")]
        public global::System.Collections.Generic.IList<double>? Sizes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qualities")]
        public global::System.Collections.Generic.IList<double>? Qualities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<string>? Domains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remotePatterns")]
        public global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2ImagesRemotePattern>? RemotePatterns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localPatterns")]
        public global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2ImagesLocalPattern>? LocalPatterns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumCacheTTL")]
        public double? MinimumCacheTTL { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        public global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2ImagesFormat>? Formats { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dangerouslyAllowSVG")]
        public bool? DangerouslyAllowSVG { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentSecurityPolicy")]
        public string? ContentSecurityPolicy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentDispositionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2ImagesContentDispositionTypeJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2ImagesContentDispositionType? ContentDispositionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2Images" /> class.
        /// </summary>
        /// <param name="sizes"></param>
        /// <param name="qualities"></param>
        /// <param name="domains"></param>
        /// <param name="remotePatterns"></param>
        /// <param name="localPatterns"></param>
        /// <param name="minimumCacheTTL"></param>
        /// <param name="formats"></param>
        /// <param name="dangerouslyAllowSVG"></param>
        /// <param name="contentSecurityPolicy"></param>
        /// <param name="contentDispositionType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2Images(
            global::System.Collections.Generic.IList<double>? sizes,
            global::System.Collections.Generic.IList<double>? qualities,
            global::System.Collections.Generic.IList<string>? domains,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2ImagesRemotePattern>? remotePatterns,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2ImagesLocalPattern>? localPatterns,
            double? minimumCacheTTL,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2ImagesFormat>? formats,
            bool? dangerouslyAllowSVG,
            string? contentSecurityPolicy,
            global::Vercel.GetDeploymentResponseVariant2ImagesContentDispositionType? contentDispositionType)
        {
            this.Sizes = sizes;
            this.Qualities = qualities;
            this.Domains = domains;
            this.RemotePatterns = remotePatterns;
            this.LocalPatterns = localPatterns;
            this.MinimumCacheTTL = minimumCacheTTL;
            this.Formats = formats;
            this.DangerouslyAllowSVG = dangerouslyAllowSVG;
            this.ContentSecurityPolicy = contentSecurityPolicy;
            this.ContentDispositionType = contentDispositionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2Images" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2Images()
        {
        }

    }
}