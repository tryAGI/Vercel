
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponseMicrofrontendsVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> GroupIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeProjectForLegacyLimits")]
        public bool? FreeProjectForLegacyLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseMicrofrontendsVariant3" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="groupIds"></param>
        /// <param name="enabled"></param>
        /// <param name="freeProjectForLegacyLimits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponseMicrofrontendsVariant3(
            double updatedAt,
            global::System.Collections.Generic.IList<object> groupIds,
            bool enabled,
            bool? freeProjectForLegacyLimits)
        {
            this.UpdatedAt = updatedAt;
            this.GroupIds = groupIds ?? throw new global::System.ArgumentNullException(nameof(groupIds));
            this.Enabled = enabled;
            this.FreeProjectForLegacyLimits = freeProjectForLegacyLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseMicrofrontendsVariant3" /> class.
        /// </summary>
        public CreateProjectResponseMicrofrontendsVariant3()
        {
        }
    }
}