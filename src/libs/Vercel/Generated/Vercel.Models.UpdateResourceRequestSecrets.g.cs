
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateResourceRequestSecrets
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecretsSecret> Secrets { get; set; }

        /// <summary>
        /// If true, will only overwrite the provided secrets instead of replacing all secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial")]
        public bool? Partial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceRequestSecrets" /> class.
        /// </summary>
        /// <param name="secrets"></param>
        /// <param name="partial">
        /// If true, will only overwrite the provided secrets instead of replacing all secrets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResourceRequestSecrets(
            global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecretsSecret> secrets,
            bool? partial)
        {
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.Partial = partial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceRequestSecrets" /> class.
        /// </summary>
        public UpdateResourceRequestSecrets()
        {
        }
    }
}