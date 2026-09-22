
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
        public global::Vercel.AutoSDKShared1ed2975831fbb888? Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public global::Vercel.AutoSDKShared1ed2975831fbb888? Draft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared7e5cde0fd7c87b94> Versions { get; set; }

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
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared7e5cde0fd7c87b94> versions,
            global::Vercel.AutoSDKShared1ed2975831fbb888? active,
            global::Vercel.AutoSDKShared1ed2975831fbb888? draft)
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