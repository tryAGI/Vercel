
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationsResponseVariant2ItemIntegration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isLegacy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLegacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        public global::System.Collections.Generic.IList<string>? Flags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignedBetaLabelAt")]
        public double? AssignedBetaLabelAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagIds")]
        public global::System.Collections.Generic.IList<global::Vercel.GetConfigurationsResponseVariant2ItemIntegrationTagId>? TagIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationsResponseVariant2ItemIntegration" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="icon"></param>
        /// <param name="isLegacy"></param>
        /// <param name="flags"></param>
        /// <param name="assignedBetaLabelAt"></param>
        /// <param name="tagIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationsResponseVariant2ItemIntegration(
            string name,
            string icon,
            bool isLegacy,
            global::System.Collections.Generic.IList<string>? flags,
            double? assignedBetaLabelAt,
            global::System.Collections.Generic.IList<global::Vercel.GetConfigurationsResponseVariant2ItemIntegrationTagId>? tagIds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
            this.IsLegacy = isLegacy;
            this.Flags = flags;
            this.AssignedBetaLabelAt = assignedBetaLabelAt;
            this.TagIds = tagIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationsResponseVariant2ItemIntegration" /> class.
        /// </summary>
        public GetConfigurationsResponseVariant2ItemIntegration()
        {
        }
    }
}