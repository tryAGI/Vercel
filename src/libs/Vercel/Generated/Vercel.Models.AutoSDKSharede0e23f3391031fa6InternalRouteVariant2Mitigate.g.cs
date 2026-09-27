
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede0e23f3391031fa6InternalRouteVariant2Mitigate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede0e23f3391031fa6InternalRouteVariant2MitigateActionJsonConverter))]
        public global::Vercel.AutoSDKSharede0e23f3391031fa6InternalRouteVariant2MitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede0e23f3391031fa6InternalRouteVariant2Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede0e23f3391031fa6InternalRouteVariant2Mitigate(
            global::Vercel.AutoSDKSharede0e23f3391031fa6InternalRouteVariant2MitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede0e23f3391031fa6InternalRouteVariant2Mitigate" /> class.
        /// </summary>
        public AutoSDKSharede0e23f3391031fa6InternalRouteVariant2Mitigate()
        {
        }

    }
}