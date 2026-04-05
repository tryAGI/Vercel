
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2AccessJsonConverter))]
        public global::Vercel.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2Access Access { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2" /> class.
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="managedBy"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2(
            global::System.Collections.Generic.IList<string> projectIds,
            global::Vercel.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedBy managedBy,
            global::Vercel.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2Access access)
        {
            this.Access = access;
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
            this.ManagedBy = managedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2" /> class.
        /// </summary>
        public GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2()
        {
        }
    }
}