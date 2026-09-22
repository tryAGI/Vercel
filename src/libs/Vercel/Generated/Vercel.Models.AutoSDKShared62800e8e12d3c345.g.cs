
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared62800e8e12d3c345
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKShared62800e8e12d3c345Destination>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.AutoSDKShared62800e8e12d3c345Destination> Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<string>? Env { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared62800e8e12d3c345HaVariant1, global::Vercel.AutoSDKShared62800e8e12d3c345HaVariant2>>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared62800e8e12d3c345MissingItemVariant1, global::Vercel.AutoSDKShared62800e8e12d3c345MissingItemVariant2>>? Missing { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared62800e8e12d3c345Transform>? Transforms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared62800e8e12d3c345" /> class.
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
        public AutoSDKShared62800e8e12d3c345(
            global::Vercel.OneOf<string, global::Vercel.AutoSDKShared62800e8e12d3c345Destination> destination,
            string source,
            global::System.Collections.Generic.IList<string>? env,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared62800e8e12d3c345HaVariant1, global::Vercel.AutoSDKShared62800e8e12d3c345HaVariant2>>? has,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared62800e8e12d3c345MissingItemVariant1, global::Vercel.AutoSDKShared62800e8e12d3c345MissingItemVariant2>>? missing,
            bool? respectOriginCacheControl,
            double? statusCode,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared62800e8e12d3c345Transform>? transforms)
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
        /// Initializes a new instance of the <see cref="AutoSDKShared62800e8e12d3c345" /> class.
        /// </summary>
        public AutoSDKShared62800e8e12d3c345()
        {
        }

    }
}