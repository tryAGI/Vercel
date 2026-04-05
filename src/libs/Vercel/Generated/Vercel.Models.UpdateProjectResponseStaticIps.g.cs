
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectResponseStaticIps
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Builds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseStaticIps" /> class.
        /// </summary>
        /// <param name="builds"></param>
        /// <param name="enabled"></param>
        /// <param name="regions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseStaticIps(
            bool builds,
            bool enabled,
            global::System.Collections.Generic.IList<string> regions)
        {
            this.Builds = builds;
            this.Enabled = enabled;
            this.Regions = regions ?? throw new global::System.ArgumentNullException(nameof(regions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseStaticIps" /> class.
        /// </summary>
        public UpdateProjectResponseStaticIps()
        {
        }
    }
}