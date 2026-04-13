
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant124FactorsVariant2ItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant124FactorsVariant2ItemVariant1OriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy")]
        public bool? Legacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoType")]
        public string? SsoType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant124FactorsVariant2ItemVariant1" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="username"></param>
        /// <param name="teamId"></param>
        /// <param name="legacy"></param>
        /// <param name="ssoType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant124FactorsVariant2ItemVariant1(
            global::Vercel.UserEventPayloadVariant124FactorsVariant2ItemVariant1Origin origin,
            string? username,
            string? teamId,
            bool? legacy,
            string? ssoType)
        {
            this.Origin = origin;
            this.Username = username;
            this.TeamId = teamId;
            this.Legacy = legacy;
            this.SsoType = ssoType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant124FactorsVariant2ItemVariant1" /> class.
        /// </summary>
        public UserEventPayloadVariant124FactorsVariant2ItemVariant1()
        {
        }
    }
}