
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSecurityFirewallConfigResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public global::Vercel.AutoSDKSharedb4cb9cbf2561e851? Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public global::Vercel.AutoSDKSharedb4cb9cbf2561e851? Draft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6ed60ada20c5170a> Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponse" /> class.
        /// </summary>
        /// <param name="versions"></param>
        /// <param name="active"></param>
        /// <param name="draft"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecurityFirewallConfigResponse(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6ed60ada20c5170a> versions,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851? active,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851? draft)
        {
            this.Active = active;
            this.Draft = draft;
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponse" /> class.
        /// </summary>
        public GetSecurityFirewallConfigResponse()
        {
        }

    }
}