
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Instance count overrides for the given regions, for example { \"iad1\": 1 }. Overrides of regions not in the map are kept. A `null` count removes the region's override. An empty map removes all overrides.
    /// </summary>
    public sealed partial class PutProjectDaemonInstancesRequest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}