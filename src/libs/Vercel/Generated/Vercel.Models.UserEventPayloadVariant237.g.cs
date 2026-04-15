
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant237
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
        public required global::Vercel.UserEventPayloadVariant237Store Store { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant237" /> class.
        /// </summary>
        /// <param name="transferRequestCode"></param>
        /// <param name="store"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant237(
            string transferRequestCode,
            global::Vercel.UserEventPayloadVariant237Store store)
        {
            this.TransferRequestCode = transferRequestCode ?? throw new global::System.ArgumentNullException(nameof(transferRequestCode));
            this.Store = store ?? throw new global::System.ArgumentNullException(nameof(store));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant237" /> class.
        /// </summary>
        public UserEventPayloadVariant237()
        {
        }
    }
}