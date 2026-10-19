
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Instance count overrides by region, for example { \"iad1\": 1 }. Regions not in the map keep their configured count. An empty map removes the overrides.
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