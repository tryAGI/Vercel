
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc1c2f92d02e0feb6InternalRouteVariant2Mitigate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc1c2f92d02e0feb6InternalRouteVariant2MitigateActionJsonConverter))]
        public global::Vercel.AutoSDKSharedc1c2f92d02e0feb6InternalRouteVariant2MitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc1c2f92d02e0feb6InternalRouteVariant2Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc1c2f92d02e0feb6InternalRouteVariant2Mitigate(
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6InternalRouteVariant2MitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc1c2f92d02e0feb6InternalRouteVariant2Mitigate" /> class.
        /// </summary>
        public AutoSDKSharedc1c2f92d02e0feb6InternalRouteVariant2Mitigate()
        {
        }

    }
}