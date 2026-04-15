
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant239
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferRequestCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransferRequestCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant239Store Store { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originTeamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginTeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originTeamName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginTeamName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant239" /> class.
        /// </summary>
        /// <param name="transferRequestCode"></param>
        /// <param name="store"></param>
        /// <param name="originTeamId"></param>
        /// <param name="originTeamName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant239(
            string transferRequestCode,
            global::Vercel.UserEventPayloadVariant239Store store,
            string originTeamId,
            string originTeamName)
        {
            this.TransferRequestCode = transferRequestCode ?? throw new global::System.ArgumentNullException(nameof(transferRequestCode));
            this.Store = store ?? throw new global::System.ArgumentNullException(nameof(store));
            this.OriginTeamId = originTeamId ?? throw new global::System.ArgumentNullException(nameof(originTeamId));
            this.OriginTeamName = originTeamName ?? throw new global::System.ArgumentNullException(nameof(originTeamName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant239" /> class.
        /// </summary>
        public UserEventPayloadVariant239()
        {
        }
    }
}