
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf5934c240f4382f7InternalRouteVariant2Mitigate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf5934c240f4382f7InternalRouteVariant2MitigateActionJsonConverter))]
        public global::Vercel.AutoSDKSharedf5934c240f4382f7InternalRouteVariant2MitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf5934c240f4382f7InternalRouteVariant2Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf5934c240f4382f7InternalRouteVariant2Mitigate(
            global::Vercel.AutoSDKSharedf5934c240f4382f7InternalRouteVariant2MitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf5934c240f4382f7InternalRouteVariant2Mitigate" /> class.
        /// </summary>
        public AutoSDKSharedf5934c240f4382f7InternalRouteVariant2Mitigate()
        {
        }

    }
}