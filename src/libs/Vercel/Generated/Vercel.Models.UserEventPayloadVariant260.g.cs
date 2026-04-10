
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant260
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousConcurrentBuilds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PreviousConcurrentBuilds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextConcurrentBuilds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NextConcurrentBuilds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant260" /> class.
        /// </summary>
        /// <param name="previousConcurrentBuilds"></param>
        /// <param name="nextConcurrentBuilds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant260(
            double previousConcurrentBuilds,
            double nextConcurrentBuilds)
        {
            this.PreviousConcurrentBuilds = previousConcurrentBuilds;
            this.NextConcurrentBuilds = nextConcurrentBuilds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant260" /> class.
        /// </summary>
        public UserEventPayloadVariant260()
        {
        }
    }
}