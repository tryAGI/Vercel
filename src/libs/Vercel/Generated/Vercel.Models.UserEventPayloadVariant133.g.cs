
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant133
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OldName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant133" /> class.
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant133(
            string oldName,
            string newName)
        {
            this.OldName = oldName ?? throw new global::System.ArgumentNullException(nameof(oldName));
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant133" /> class.
        /// </summary>
        public UserEventPayloadVariant133()
        {
        }
    }
}