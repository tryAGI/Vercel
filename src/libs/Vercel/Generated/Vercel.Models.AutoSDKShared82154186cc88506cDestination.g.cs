
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared82154186cc88506cDestination
    {
        /// <summary>
        /// Routing-only path used to select a route inside the target service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// Optional explicit format marker. The destination is identified by the presence of `service`, so `type` is no longer required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared82154186cc88506cDestinationTypeJsonConverter))]
        public global::Vercel.AutoSDKShared82154186cc88506cDestinationType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared82154186cc88506cDestination" /> class.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="path">
        /// Routing-only path used to select a route inside the target service.
        /// </param>
        /// <param name="type">
        /// Optional explicit format marker. The destination is identified by the presence of `service`, so `type` is no longer required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared82154186cc88506cDestination(
            string service,
            string? path,
            global::Vercel.AutoSDKShared82154186cc88506cDestinationType? type)
        {
            this.Path = path;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared82154186cc88506cDestination" /> class.
        /// </summary>
        public AutoSDKShared82154186cc88506cDestination()
        {
        }

    }
}