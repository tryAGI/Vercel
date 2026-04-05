
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2Mitigate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2MitigateActionJsonConverter))]
        public global::Vercel.GetProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2Mitigate(
            global::Vercel.GetProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2Mitigate" /> class.
        /// </summary>
        public GetProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2Mitigate()
        {
        }
    }
}