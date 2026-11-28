
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2Mitigate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2MitigateActionJsonConverter))]
        public global::Vercel.AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2MitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2Mitigate(
            global::Vercel.AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2MitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2Mitigate" /> class.
        /// </summary>
        public AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2Mitigate()
        {
        }

    }
}