
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant224
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedProjects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant224AddedProject> AddedProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedProjects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant224RemovedProject> RemovedProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedProviders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AddedProviders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedProviders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RemovedProviders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant224" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="addedProjects"></param>
        /// <param name="removedProjects"></param>
        /// <param name="addedProviders"></param>
        /// <param name="removedProviders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant224(
            string projectId,
            string projectName,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant224AddedProject> addedProjects,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant224RemovedProject> removedProjects,
            global::System.Collections.Generic.IList<string> addedProviders,
            global::System.Collections.Generic.IList<string> removedProviders)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.AddedProjects = addedProjects ?? throw new global::System.ArgumentNullException(nameof(addedProjects));
            this.RemovedProjects = removedProjects ?? throw new global::System.ArgumentNullException(nameof(removedProjects));
            this.AddedProviders = addedProviders ?? throw new global::System.ArgumentNullException(nameof(addedProviders));
            this.RemovedProviders = removedProviders ?? throw new global::System.ArgumentNullException(nameof(removedProviders));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant224" /> class.
        /// </summary>
        public UserEventPayloadVariant224()
        {
        }
    }
}