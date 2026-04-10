
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant115NewOwnerDismissedToast
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
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerDismissedToastDismissal> Dismissals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerDismissedToast" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dismissals"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant115NewOwnerDismissedToast(
            string name,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerDismissedToastDismissal> dismissals)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Dismissals = dismissals ?? throw new global::System.ArgumentNullException(nameof(dismissals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerDismissedToast" /> class.
        /// </summary>
        public UserEventPayloadVariant115NewOwnerDismissedToast()
        {
        }
    }
}