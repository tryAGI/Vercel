
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecurityFirewallConfigByConfigVersionActivateResponseCrs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSd Sd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ma")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsMa Ma { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsLfi Lfi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRfi Rfi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRce Rce { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("php")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsPhp Php { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsGen Gen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsXss Xss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sqli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSqli Sqli { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSf Sf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("java")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsJava Java { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecurityFirewallConfigByConfigVersionActivateResponseCrs" /> class.
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
        public CreateSecurityFirewallConfigByConfigVersionActivateResponseCrs(
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSd sd,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsMa ma,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsLfi lfi,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRfi rfi,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRce rce,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsPhp php,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsGen gen,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsXss xss,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSqli sqli,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSf sf,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsJava java)
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
        /// Initializes a new instance of the <see cref="CreateSecurityFirewallConfigByConfigVersionActivateResponseCrs" /> class.
        /// </summary>
        public CreateSecurityFirewallConfigByConfigVersionActivateResponseCrs()
        {
        }

    }
}