
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant185
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant185Project> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant185" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="uid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant185(
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant185Project> projects,
            string uid)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant185" /> class.
        /// </summary>
        public UserEventPayloadVariant185()
        {
        }
    }
}