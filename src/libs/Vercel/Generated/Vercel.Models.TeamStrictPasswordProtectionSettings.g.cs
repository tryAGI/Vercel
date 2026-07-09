
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When enabled, adding, changing, or removing project password protection requires Owner role.
    /// </summary>
    public sealed partial class TeamStrictPasswordProtectionSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamStrictPasswordProtectionSettings" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamStrictPasswordProtectionSettings(
            bool enabled,
            double updatedAt)
        {
            this.Enabled = enabled;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamStrictPasswordProtectionSettings" /> class.
        /// </summary>
        public TeamStrictPasswordProtectionSettings()
        {
        }

    }
}