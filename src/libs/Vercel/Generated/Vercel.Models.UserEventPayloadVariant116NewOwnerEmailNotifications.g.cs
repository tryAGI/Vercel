
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant116NewOwnerEmailNotifications
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant116NewOwnerEmailNotificationsRules2>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerEmailNotifications" /> class.
        /// </summary>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant116NewOwnerEmailNotifications(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant116NewOwnerEmailNotificationsRules2>? rules)
        {
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerEmailNotifications" /> class.
        /// </summary>
        public UserEventPayloadVariant116NewOwnerEmailNotifications()
        {
        }
    }
}