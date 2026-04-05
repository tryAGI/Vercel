
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant65
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant65Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant65Job Job { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant65" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="job"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant65(
            global::Vercel.UserEventPayloadVariant65Project project,
            global::Vercel.UserEventPayloadVariant65Job job)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant65" /> class.
        /// </summary>
        public UserEventPayloadVariant65()
        {
        }
    }
}