
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateVercelCiRepositorySettingsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repository { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ciEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CiEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ciEnabledAt")]
        public double? CiEnabledAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVercelCiRepositorySettingsResponse" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="organizationId"></param>
        /// <param name="repository"></param>
        /// <param name="ciEnabled"></param>
        /// <param name="ciEnabledAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVercelCiRepositorySettingsResponse(
            string provider,
            string organizationId,
            string repository,
            bool ciEnabled,
            double? ciEnabledAt,
            double? updatedAt)
        {
            this.Provider = provider;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.CiEnabled = ciEnabled;
            this.CiEnabledAt = ciEnabledAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVercelCiRepositorySettingsResponse" /> class.
        /// </summary>
        public UpdateVercelCiRepositorySettingsResponse()
        {
        }

    }
}