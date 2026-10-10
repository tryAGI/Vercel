
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateVercelCiRepositorySettingsRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ciEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CiEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVercelCiRepositorySettingsRequest" /> class.
        /// </summary>
        /// <param name="ciEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVercelCiRepositorySettingsRequest(
            bool ciEnabled)
        {
            this.CiEnabled = ciEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVercelCiRepositorySettingsRequest" /> class.
        /// </summary>
        public UpdateVercelCiRepositorySettingsRequest()
        {
        }

    }
}