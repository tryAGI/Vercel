
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant284Peering
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpcId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VpcId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant284Peering" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="accountId"></param>
        /// <param name="region"></param>
        /// <param name="vpcId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant284Peering(
            string id,
            string accountId,
            string region,
            string vpcId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.VpcId = vpcId ?? throw new global::System.ArgumentNullException(nameof(vpcId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant284Peering" /> class.
        /// </summary>
        public UserEventPayloadVariant284Peering()
        {
        }
    }
}