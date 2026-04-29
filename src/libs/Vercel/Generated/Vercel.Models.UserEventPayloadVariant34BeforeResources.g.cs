
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant34BeforeResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant34BeforeResourcesProjectIds ProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant34BeforeResources" /> class.
        /// </summary>
        /// <param name="projectIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant34BeforeResources(
            global::Vercel.UserEventPayloadVariant34BeforeResourcesProjectIds projectIds)
        {
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant34BeforeResources" /> class.
        /// </summary>
        public UserEventPayloadVariant34BeforeResources()
        {
        }
    }
}