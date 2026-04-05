
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata about any projects associated with the Network.
    /// </summary>
    public sealed partial class NetworkProjects
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkProjects" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="ids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkProjects(
            double count,
            global::System.Collections.Generic.IList<string> ids)
        {
            this.Count = count;
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkProjects" /> class.
        /// </summary>
        public NetworkProjects()
        {
        }
    }
}