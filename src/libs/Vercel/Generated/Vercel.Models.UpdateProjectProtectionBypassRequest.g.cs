
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectProtectionBypassRequest
    {
        /// <summary>
        /// Optional instructions for revoking and regenerating a automation bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoke")]
        public global::Vercel.UpdateProjectProtectionBypassRequestRevoke? Revoke { get; set; }

        /// <summary>
        /// Generate a new secret. If neither generate or revoke are provided, a new random secret will be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate")]
        public global::Vercel.UpdateProjectProtectionBypassRequestGenerate? Generate { get; set; }

        /// <summary>
        /// Update an existing bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update")]
        public global::Vercel.UpdateProjectProtectionBypassRequestUpdate? Update { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectProtectionBypassRequest" /> class.
        /// </summary>
        /// <param name="revoke">
        /// Optional instructions for revoking and regenerating a automation bypass
        /// </param>
        /// <param name="generate">
        /// Generate a new secret. If neither generate or revoke are provided, a new random secret will be generated.
        /// </param>
        /// <param name="update">
        /// Update an existing bypass
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectProtectionBypassRequest(
            global::Vercel.UpdateProjectProtectionBypassRequestRevoke? revoke,
            global::Vercel.UpdateProjectProtectionBypassRequestGenerate? generate,
            global::Vercel.UpdateProjectProtectionBypassRequestUpdate? update)
        {
            this.Revoke = revoke;
            this.Generate = generate;
            this.Update = update;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectProtectionBypassRequest" /> class.
        /// </summary>
        public UpdateProjectProtectionBypassRequest()
        {
        }
    }
}