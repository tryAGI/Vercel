
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Manage Static IPs for this project
    /// </summary>
    public sealed partial class UpdateProjectRequestStaticIps
    {
        /// <summary>
        /// Opt-in to Static IPs for this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestStaticIps" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Opt-in to Static IPs for this project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestStaticIps(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestStaticIps" /> class.
        /// </summary>
        public UpdateProjectRequestStaticIps()
        {
        }
    }
}