
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSecurityFirewallConfigResponseVersionCrs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsSd Sd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ma")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsMa Ma { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsLfi Lfi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsRfi Rfi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsRce Rce { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("php")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsPhp Php { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsGen Gen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsXss Xss { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sqli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsSqli Sqli { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsSf Sf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("java")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSecurityFirewallConfigResponseVersionCrsJava Java { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponseVersionCrs" /> class.
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
        public GetSecurityFirewallConfigResponseVersionCrs(
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsSd sd,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsMa ma,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsLfi lfi,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsRfi rfi,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsRce rce,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsPhp php,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsGen gen,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsXss xss,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsSqli sqli,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsSf sf,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrsJava java)
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
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponseVersionCrs" /> class.
        /// </summary>
        public GetSecurityFirewallConfigResponseVersionCrs()
        {
        }

    }
}