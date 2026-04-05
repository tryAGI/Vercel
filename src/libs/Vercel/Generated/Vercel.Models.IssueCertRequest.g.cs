
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssueCertRequest
    {
        /// <summary>
        /// The common names the cert should be issued for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cns")]
        public global::System.Collections.Generic.IList<string>? Cns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueCertRequest" /> class.
        /// </summary>
        /// <param name="cns">
        /// The common names the cert should be issued for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueCertRequest(
            global::System.Collections.Generic.IList<string>? cns)
        {
            this.Cns = cns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueCertRequest" /> class.
        /// </summary>
        public IssueCertRequest()
        {
        }
    }
}