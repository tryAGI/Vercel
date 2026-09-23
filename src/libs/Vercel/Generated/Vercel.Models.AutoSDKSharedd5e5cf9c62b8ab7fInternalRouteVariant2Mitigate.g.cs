
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd5e5cf9c62b8ab7fInternalRouteVariant2Mitigate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd5e5cf9c62b8ab7fInternalRouteVariant2MitigateActionJsonConverter))]
        public global::Vercel.AutoSDKSharedd5e5cf9c62b8ab7fInternalRouteVariant2MitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5e5cf9c62b8ab7fInternalRouteVariant2Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd5e5cf9c62b8ab7fInternalRouteVariant2Mitigate(
            global::Vercel.AutoSDKSharedd5e5cf9c62b8ab7fInternalRouteVariant2MitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5e5cf9c62b8ab7fInternalRouteVariant2Mitigate" /> class.
        /// </summary>
        public AutoSDKSharedd5e5cf9c62b8ab7fInternalRouteVariant2Mitigate()
        {
        }

    }
}