
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSecurityFirewallConfigResponseActiveCrs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsSd Sd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ma")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsMa Ma { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsLfi Lfi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsRfi Rfi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsRce Rce { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("php")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsPhp Php { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsGen Gen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsXss Xss { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sqli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsSqli Sqli { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsSf Sf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("java")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseActiveCrsJava Java { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponseActiveCrs" /> class.
        /// </summary>
        /// <param name="sd"></param>
        /// <param name="ma"></param>
        /// <param name="lfi"></param>
        /// <param name="rfi"></param>
        /// <param name="rce"></param>
        /// <param name="php"></param>
        /// <param name="gen"></param>
        /// <param name="xss"></param>
        /// <param name="sqli"></param>
        /// <param name="sf"></param>
        /// <param name="java"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecurityFirewallConfigResponseActiveCrs(
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsSd sd,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsMa ma,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsLfi lfi,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsRfi rfi,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsRce rce,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsPhp php,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsGen gen,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsXss xss,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsSqli sqli,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsSf sf,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsJava java)
        {
            this.Sd = sd ?? throw new global::System.ArgumentNullException(nameof(sd));
            this.Ma = ma ?? throw new global::System.ArgumentNullException(nameof(ma));
            this.Lfi = lfi ?? throw new global::System.ArgumentNullException(nameof(lfi));
            this.Rfi = rfi ?? throw new global::System.ArgumentNullException(nameof(rfi));
            this.Rce = rce ?? throw new global::System.ArgumentNullException(nameof(rce));
            this.Php = php ?? throw new global::System.ArgumentNullException(nameof(php));
            this.Gen = gen ?? throw new global::System.ArgumentNullException(nameof(gen));
            this.Xss = xss ?? throw new global::System.ArgumentNullException(nameof(xss));
            this.Sqli = sqli ?? throw new global::System.ArgumentNullException(nameof(sqli));
            this.Sf = sf ?? throw new global::System.ArgumentNullException(nameof(sf));
            this.Java = java ?? throw new global::System.ArgumentNullException(nameof(java));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponseActiveCrs" /> class.
        /// </summary>
        public GetSecurityFirewallConfigResponseActiveCrs()
        {
        }

    }
}