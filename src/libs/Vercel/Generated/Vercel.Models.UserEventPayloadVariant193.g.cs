
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant193
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant193Project> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryType")]
        public string? DirectoryType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant193" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="uid"></param>
        /// <param name="directoryType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant193(
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant193Project> projects,
            string uid,
            string? directoryType)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.DirectoryType = directoryType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant193" /> class.
        /// </summary>
        public UserEventPayloadVariant193()
        {
        }
    }
}