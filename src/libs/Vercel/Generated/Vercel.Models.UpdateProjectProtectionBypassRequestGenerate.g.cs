
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generate a new secret. If neither generate or revoke are provided, a new random secret will be generated.
    /// </summary>
    public sealed partial class UpdateProjectProtectionBypassRequestGenerate
    {
        /// <summary>
        /// Optional value of the secret to generate, don't send it for oauth2 tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateProjectProtectionBypassRequestGenerate" /> class.
        /// </summary>
        /// <param name="secret">
        /// Optional value of the secret to generate, don't send it for oauth2 tokens
        /// </param>
        /// <param name="note">
        /// Note to be displayed in the UI for this bypass
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectProtectionBypassRequestGenerate(
            string? secret,
            string? note)
        {
            this.Secret = secret;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectProtectionBypassRequestGenerate" /> class.
        /// </summary>
        public UpdateProjectProtectionBypassRequestGenerate()
        {
        }
    }
}