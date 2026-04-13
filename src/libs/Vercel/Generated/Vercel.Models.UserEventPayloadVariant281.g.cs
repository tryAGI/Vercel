
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant281
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevEmail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrevEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant281" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="prevEmail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant281(
            string email,
            string prevEmail)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.PrevEmail = prevEmail ?? throw new global::System.ArgumentNullException(nameof(prevEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant281" /> class.
        /// </summary>
        public UserEventPayloadVariant281()
        {
        }
    }
}