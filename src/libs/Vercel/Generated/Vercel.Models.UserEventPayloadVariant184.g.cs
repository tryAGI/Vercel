
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant184
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant184Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedMembership")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant184RemovedMembership RemovedMembership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant184" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="removedMembership"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant184(
            global::Vercel.UserEventPayloadVariant184Project project,
            global::Vercel.UserEventPayloadVariant184RemovedMembership removedMembership)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.RemovedMembership = removedMembership ?? throw new global::System.ArgumentNullException(nameof(removedMembership));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant184" /> class.
        /// </summary>
        public UserEventPayloadVariant184()
        {
        }
    }
}