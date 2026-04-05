
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Custom Ruleset
    /// </summary>
    public sealed partial class GetFirewallConfigResponseCrs
    {
        /// <summary>
        /// Scanner Detection - Detect and prevent reconnaissance activities from network scanning tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsSd Sd { get; set; }

        /// <summary>
        /// Multipart Attack - Block attempts to bypass security controls using multipart/form-data encoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ma")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsMa Ma { get; set; }

        /// <summary>
        /// Local File Inclusion Attack - Prevent unauthorized access to local files through web applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsLfi Lfi { get; set; }

        /// <summary>
        /// Remote File Inclusion Attack - Prohibit unauthorized upload or execution of remote files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsRfi Rfi { get; set; }

        /// <summary>
        /// Remote Execution Attack - Prevent unauthorized execution of remote scripts or commands.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsRce Rce { get; set; }

        /// <summary>
        /// PHP Attack - Safeguard against vulnerability exploits in PHP-based applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("php")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsPhp Php { get; set; }

        /// <summary>
        /// Generic Attack - Provide broad protection from various undefined or novel attack vectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsGen Gen { get; set; }

        /// <summary>
        /// XSS Attack - Prevent injection of malicious scripts into trusted webpages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsXss Xss { get; set; }

        /// <summary>
        /// SQL Injection Attack - Prohibit unauthorized use of SQL commands to manipulate databases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sqli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsSqli Sqli { get; set; }

        /// <summary>
        /// Session Fixation Attack - Prevent unauthorized takeover of user sessions by enforcing unique session IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsSf Sf { get; set; }

        /// <summary>
        /// Java Attack - Mitigate risks of exploitation targeting Java-based applications or components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("java")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsJava Java { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseCrs" /> class.
        /// </summary>
        /// <param name="sd">
        /// Scanner Detection - Detect and prevent reconnaissance activities from network scanning tools.
        /// </param>
        /// <param name="ma">
        /// Multipart Attack - Block attempts to bypass security controls using multipart/form-data encoding.
        /// </param>
        /// <param name="lfi">
        /// Local File Inclusion Attack - Prevent unauthorized access to local files through web applications.
        /// </param>
        /// <param name="rfi">
        /// Remote File Inclusion Attack - Prohibit unauthorized upload or execution of remote files.
        /// </param>
        /// <param name="rce">
        /// Remote Execution Attack - Prevent unauthorized execution of remote scripts or commands.
        /// </param>
        /// <param name="php">
        /// PHP Attack - Safeguard against vulnerability exploits in PHP-based applications.
        /// </param>
        /// <param name="gen">
        /// Generic Attack - Provide broad protection from various undefined or novel attack vectors.
        /// </param>
        /// <param name="xss">
        /// XSS Attack - Prevent injection of malicious scripts into trusted webpages.
        /// </param>
        /// <param name="sqli">
        /// SQL Injection Attack - Prohibit unauthorized use of SQL commands to manipulate databases.
        /// </param>
        /// <param name="sf">
        /// Session Fixation Attack - Prevent unauthorized takeover of user sessions by enforcing unique session IDs.
        /// </param>
        /// <param name="java">
        /// Java Attack - Mitigate risks of exploitation targeting Java-based applications or components.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFirewallConfigResponseCrs(
            global::Vercel.GetFirewallConfigResponseCrsSd sd,
            global::Vercel.GetFirewallConfigResponseCrsMa ma,
            global::Vercel.GetFirewallConfigResponseCrsLfi lfi,
            global::Vercel.GetFirewallConfigResponseCrsRfi rfi,
            global::Vercel.GetFirewallConfigResponseCrsRce rce,
            global::Vercel.GetFirewallConfigResponseCrsPhp php,
            global::Vercel.GetFirewallConfigResponseCrsGen gen,
            global::Vercel.GetFirewallConfigResponseCrsXss xss,
            global::Vercel.GetFirewallConfigResponseCrsSqli sqli,
            global::Vercel.GetFirewallConfigResponseCrsSf sf,
            global::Vercel.GetFirewallConfigResponseCrsJava java)
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
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseCrs" /> class.
        /// </summary>
        public GetFirewallConfigResponseCrs()
        {
        }
    }
}