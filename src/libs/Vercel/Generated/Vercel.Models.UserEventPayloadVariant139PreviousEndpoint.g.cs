
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant139PreviousEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentIds")]
        public global::System.Collections.Generic.IList<string>? EnvironmentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateDnsNames")]
        public global::System.Collections.Generic.IList<string>? PrivateDnsNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant139PreviousEndpoint" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="environmentIds"></param>
        /// <param name="privateDnsNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant139PreviousEndpoint(
            string name,
            global::System.Collections.Generic.IList<string>? environmentIds,
            global::System.Collections.Generic.IList<string>? privateDnsNames)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EnvironmentIds = environmentIds;
            this.PrivateDnsNames = privateDnsNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant139PreviousEndpoint" /> class.
        /// </summary>
        public UserEventPayloadVariant139PreviousEndpoint()
        {
        }
    }
}