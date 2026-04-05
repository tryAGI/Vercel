
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadCertRequest
    {
        /// <summary>
        /// The certificate authority
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ca")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ca { get; set; }

        /// <summary>
        /// The certificate key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The certificate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cert")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cert { get; set; }

        /// <summary>
        /// Skip validation of the certificate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipValidation")]
        public bool? SkipValidation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCertRequest" /> class.
        /// </summary>
        /// <param name="ca">
        /// The certificate authority
        /// </param>
        /// <param name="key">
        /// The certificate key
        /// </param>
        /// <param name="cert">
        /// The certificate
        /// </param>
        /// <param name="skipValidation">
        /// Skip validation of the certificate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadCertRequest(
            string ca,
            string key,
            string cert,
            bool? skipValidation)
        {
            this.Ca = ca ?? throw new global::System.ArgumentNullException(nameof(ca));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Cert = cert ?? throw new global::System.ArgumentNullException(nameof(cert));
            this.SkipValidation = skipValidation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCertRequest" /> class.
        /// </summary>
        public UploadCertRequest()
        {
        }
    }
}