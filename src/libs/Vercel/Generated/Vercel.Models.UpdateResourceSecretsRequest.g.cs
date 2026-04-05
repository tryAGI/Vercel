
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateResourceSecretsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateResourceSecretsRequestSecret> Secrets { get; set; }

        /// <summary>
        /// If true, will only update the provided secrets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial")]
        public bool? Partial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceSecretsRequest" /> class.
        /// </summary>
        /// <param name="secrets"></param>
        /// <param name="partial">
        /// If true, will only update the provided secrets
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResourceSecretsRequest(
            global::System.Collections.Generic.IList<global::Vercel.UpdateResourceSecretsRequestSecret> secrets,
            bool? partial)
        {
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.Partial = partial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceSecretsRequest" /> class.
        /// </summary>
        public UpdateResourceSecretsRequest()
        {
        }
    }
}