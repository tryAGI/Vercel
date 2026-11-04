
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared82154186cc88506c
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKShared82154186cc88506cDestination>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.AutoSDKShared82154186cc88506cDestination> Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<string>? Env { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared82154186cc88506cHaVariant1, global::Vercel.AutoSDKShared82154186cc88506cHaVariant2>>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared82154186cc88506cMissingItemVariant1, global::Vercel.AutoSDKShared82154186cc88506cMissingItemVariant2>>? Missing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respectOriginCacheControl")]
        public bool? RespectOriginCacheControl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared82154186cc88506cTransform>? Transforms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared82154186cc88506c" /> class.
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="source"></param>
        /// <param name="env"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="respectOriginCacheControl"></param>
        /// <param name="statusCode"></param>
        /// <param name="transforms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared82154186cc88506c(
            global::Vercel.OneOf<string, global::Vercel.AutoSDKShared82154186cc88506cDestination> destination,
            string source,
            global::System.Collections.Generic.IList<string>? env,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared82154186cc88506cHaVariant1, global::Vercel.AutoSDKShared82154186cc88506cHaVariant2>>? has,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared82154186cc88506cMissingItemVariant1, global::Vercel.AutoSDKShared82154186cc88506cMissingItemVariant2>>? missing,
            bool? respectOriginCacheControl,
            double? statusCode,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared82154186cc88506cTransform>? transforms)
        {
            this.Destination = destination;
            this.Env = env;
            this.Has = has;
            this.Missing = missing;
            this.RespectOriginCacheControl = respectOriginCacheControl;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.StatusCode = statusCode;
            this.Transforms = transforms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared82154186cc88506c" /> class.
        /// </summary>
        public AutoSDKShared82154186cc88506c()
        {
        }

    }
}