
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4RouteVariant2Mitigate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4RouteVariant2MitigateActionJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4RouteVariant2MitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4RouteVariant2Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4RouteVariant2Mitigate(
            global::Vercel.GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4RouteVariant2MitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4RouteVariant2Mitigate" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4RouteVariant2Mitigate()
        {
        }
    }
}