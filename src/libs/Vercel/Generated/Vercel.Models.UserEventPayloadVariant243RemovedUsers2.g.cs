
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant243RemovedUsers2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant243RemovedUsersRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant243RemovedUsersRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Confirmed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmedAt")]
        public double? ConfirmedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant243RemovedUsers2" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="confirmed"></param>
        /// <param name="confirmedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant243RemovedUsers2(
            global::Vercel.UserEventPayloadVariant243RemovedUsersRole role,
            bool confirmed,
            double? confirmedAt)
        {
            this.Role = role;
            this.Confirmed = confirmed;
            this.ConfirmedAt = confirmedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant243RemovedUsers2" /> class.
        /// </summary>
        public UserEventPayloadVariant243RemovedUsers2()
        {
        }
    }
}