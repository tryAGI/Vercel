
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant230
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant230Budget Budget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant230" /> class.
        /// </summary>
        /// <param name="budget"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant230(
            global::Vercel.UserEventPayloadVariant230Budget budget)
        {
            this.Budget = budget ?? throw new global::System.ArgumentNullException(nameof(budget));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant230" /> class.
        /// </summary>
        public UserEventPayloadVariant230()
        {
        }
    }
}