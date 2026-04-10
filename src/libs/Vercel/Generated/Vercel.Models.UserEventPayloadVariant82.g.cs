
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant82
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousServiceType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousServiceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nameservers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Nameservers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant82" /> class.
        /// </summary>
        /// <param name="previousServiceType"></param>
        /// <param name="serviceType"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameservers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant82(
            string previousServiceType,
            string serviceType,
            string id,
            string name,
            global::System.Collections.Generic.IList<string> nameservers)
        {
            this.PreviousServiceType = previousServiceType ?? throw new global::System.ArgumentNullException(nameof(previousServiceType));
            this.ServiceType = serviceType ?? throw new global::System.ArgumentNullException(nameof(serviceType));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Nameservers = nameservers ?? throw new global::System.ArgumentNullException(nameof(nameservers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant82" /> class.
        /// </summary>
        public UserEventPayloadVariant82()
        {
        }
    }
}