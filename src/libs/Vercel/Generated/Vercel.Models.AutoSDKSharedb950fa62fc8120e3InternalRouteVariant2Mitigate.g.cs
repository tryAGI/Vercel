
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedb950fa62fc8120e3InternalRouteVariant2Mitigate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedb950fa62fc8120e3InternalRouteVariant2MitigateActionJsonConverter))]
        public global::Vercel.AutoSDKSharedb950fa62fc8120e3InternalRouteVariant2MitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb950fa62fc8120e3InternalRouteVariant2Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb950fa62fc8120e3InternalRouteVariant2Mitigate(
            global::Vercel.AutoSDKSharedb950fa62fc8120e3InternalRouteVariant2MitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb950fa62fc8120e3InternalRouteVariant2Mitigate" /> class.
        /// </summary>
        public AutoSDKSharedb950fa62fc8120e3InternalRouteVariant2Mitigate()
        {
        }

    }
}