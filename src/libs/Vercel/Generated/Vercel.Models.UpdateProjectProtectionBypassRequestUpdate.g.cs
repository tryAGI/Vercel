
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Update an existing bypass
    /// </summary>
    public sealed partial class UpdateProjectProtectionBypassRequestUpdate
    {
        /// <summary>
        /// Automation bypass to updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// Whether or not this bypass is set as the VERCEL_AUTOMATION_BYPASS_SECRET environment variable on deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnvVar")]
        public bool? IsEnvVar { get; set; }

        /// <summary>
        /// Note to be displayed in the UI for this bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectProtectionBypassRequestUpdate" /> class.
        /// </summary>
        /// <param name="secret">
        /// Automation bypass to updated
        /// </param>
        /// <param name="isEnvVar">
        /// Whether or not this bypass is set as the VERCEL_AUTOMATION_BYPASS_SECRET environment variable on deployments
        /// </param>
        /// <param name="note">
        /// Note to be displayed in the UI for this bypass
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectProtectionBypassRequestUpdate(
            string secret,
            bool? isEnvVar,
            string? note)
        {
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
            this.IsEnvVar = isEnvVar;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectProtectionBypassRequestUpdate" /> class.
        /// </summary>
        public UpdateProjectProtectionBypassRequestUpdate()
        {
        }
    }
}