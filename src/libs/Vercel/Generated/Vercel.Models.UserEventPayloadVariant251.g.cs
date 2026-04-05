
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant251
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entitlement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant251User User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousCanceledAt")]
        public string? PreviousCanceledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant251" /> class.
        /// </summary>
        /// <param name="entitlement"></param>
        /// <param name="user"></param>
        /// <param name="previousCanceledAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant251(
            string entitlement,
            global::Vercel.UserEventPayloadVariant251User user,
            string? previousCanceledAt)
        {
            this.Entitlement = entitlement ?? throw new global::System.ArgumentNullException(nameof(entitlement));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.PreviousCanceledAt = previousCanceledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant251" /> class.
        /// </summary>
        public UserEventPayloadVariant251()
        {
        }
    }
}