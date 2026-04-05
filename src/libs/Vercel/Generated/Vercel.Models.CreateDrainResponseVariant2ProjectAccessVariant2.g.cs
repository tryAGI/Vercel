
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainResponseVariant2ProjectAccessVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainResponseVariant2ProjectAccessVariant2AccessJsonConverter))]
        public global::Vercel.CreateDrainResponseVariant2ProjectAccessVariant2Access Access { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainResponseVariant2ProjectAccessVariant2ManagedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDrainResponseVariant2ProjectAccessVariant2ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant2ProjectAccessVariant2" /> class.
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="managedBy"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainResponseVariant2ProjectAccessVariant2(
            global::System.Collections.Generic.IList<string> projectIds,
            global::Vercel.CreateDrainResponseVariant2ProjectAccessVariant2ManagedBy managedBy,
            global::Vercel.CreateDrainResponseVariant2ProjectAccessVariant2Access access)
        {
            this.Access = access;
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
            this.ManagedBy = managedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant2ProjectAccessVariant2" /> class.
        /// </summary>
        public CreateDrainResponseVariant2ProjectAccessVariant2()
        {
        }
    }
}