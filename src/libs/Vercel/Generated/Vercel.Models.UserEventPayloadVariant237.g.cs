
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant237
    {
        /// <summary>
        /// Represents a budget for tracking and notifying teams on their spending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant237Budget Budget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant237" /> class.
        /// </summary>
        /// <param name="budget">
        /// Represents a budget for tracking and notifying teams on their spending.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant237(
            global::Vercel.UserEventPayloadVariant237Budget budget)
        {
            this.Budget = budget ?? throw new global::System.ArgumentNullException(nameof(budget));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant237" /> class.
        /// </summary>
        public UserEventPayloadVariant237()
        {
        }
    }
}