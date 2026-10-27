
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedfc5823c22a1eaa2bInternalRouteVariant2Mitigate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedfc5823c22a1eaa2bInternalRouteVariant2MitigateActionJsonConverter))]
        public global::Vercel.AutoSDKSharedfc5823c22a1eaa2bInternalRouteVariant2MitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfc5823c22a1eaa2bInternalRouteVariant2Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedfc5823c22a1eaa2bInternalRouteVariant2Mitigate(
            global::Vercel.AutoSDKSharedfc5823c22a1eaa2bInternalRouteVariant2MitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfc5823c22a1eaa2bInternalRouteVariant2Mitigate" /> class.
        /// </summary>
        public AutoSDKSharedfc5823c22a1eaa2bInternalRouteVariant2Mitigate()
        {
        }

    }
}