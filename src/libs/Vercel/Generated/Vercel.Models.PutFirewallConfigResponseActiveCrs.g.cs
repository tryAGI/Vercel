
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Custom Ruleset
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActiveCrs
    {
        /// <summary>
        /// Generic Attack - Provide broad protection from various undefined or novel attack vectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsGen Gen { get; set; }

        /// <summary>
        /// Java Attack - Mitigate risks of exploitation targeting Java-based applications or components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("java")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsJava Java { get; set; }

        /// <summary>
        /// Local File Inclusion Attack - Prevent unauthorized access to local files through web applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsLfi Lfi { get; set; }

        /// <summary>
        /// Multipart Attack - Block attempts to bypass security controls using multipart/form-data encoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ma")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsMa Ma { get; set; }

        /// <summary>
        /// PHP Attack - Safeguard against vulnerability exploits in PHP-based applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("php")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsPhp Php { get; set; }

        /// <summary>
        /// Remote Execution Attack - Prevent unauthorized execution of remote scripts or commands.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsRce Rce { get; set; }

        /// <summary>
        /// Remote File Inclusion Attack - Prohibit unauthorized upload or execution of remote files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsRfi Rfi { get; set; }

        /// <summary>
        /// Scanner Detection - Detect and prevent reconnaissance activities from network scanning tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsSd Sd { get; set; }

        /// <summary>
        /// Session Fixation Attack - Prevent unauthorized takeover of user sessions by enforcing unique session IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsSf Sf { get; set; }

        /// <summary>
        /// SQL Injection Attack - Prohibit unauthorized use of SQL commands to manipulate databases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sqli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsSqli Sqli { get; set; }

        /// <summary>
        /// XSS Attack - Prevent injection of malicious scripts into trusted webpages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsXss Xss { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveCrs" /> class.
        /// </summary>
        /// <param name="gen">
        /// Generic Attack - Provide broad protection from various undefined or novel attack vectors.
        /// </param>
        /// <param name="java">
        /// Java Attack - Mitigate risks of exploitation targeting Java-based applications or components.
        /// </param>
        /// <param name="lfi">
        /// Local File Inclusion Attack - Prevent unauthorized access to local files through web applications.
        /// </param>
        /// <param name="ma">
        /// Multipart Attack - Block attempts to bypass security controls using multipart/form-data encoding.
        /// </param>
        /// <param name="php">
        /// PHP Attack - Safeguard against vulnerability exploits in PHP-based applications.
        /// </param>
        /// <param name="rce">
        /// Remote Execution Attack - Prevent unauthorized execution of remote scripts or commands.
        /// </param>
        /// <param name="rfi">
        /// Remote File Inclusion Attack - Prohibit unauthorized upload or execution of remote files.
        /// </param>
        /// <param name="sd">
        /// Scanner Detection - Detect and prevent reconnaissance activities from network scanning tools.
        /// </param>
        /// <param name="sf">
        /// Session Fixation Attack - Prevent unauthorized takeover of user sessions by enforcing unique session IDs.
        /// </param>
        /// <param name="sqli">
        /// SQL Injection Attack - Prohibit unauthorized use of SQL commands to manipulate databases.
        /// </param>
        /// <param name="xss">
        /// XSS Attack - Prevent injection of malicious scripts into trusted webpages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigResponseActiveCrs(
            global::Vercel.PutFirewallConfigResponseActiveCrsGen gen,
            global::Vercel.PutFirewallConfigResponseActiveCrsJava java,
            global::Vercel.PutFirewallConfigResponseActiveCrsLfi lfi,
            global::Vercel.PutFirewallConfigResponseActiveCrsMa ma,
            global::Vercel.PutFirewallConfigResponseActiveCrsPhp php,
            global::Vercel.PutFirewallConfigResponseActiveCrsRce rce,
            global::Vercel.PutFirewallConfigResponseActiveCrsRfi rfi,
            global::Vercel.PutFirewallConfigResponseActiveCrsSd sd,
            global::Vercel.PutFirewallConfigResponseActiveCrsSf sf,
            global::Vercel.PutFirewallConfigResponseActiveCrsSqli sqli,
            global::Vercel.PutFirewallConfigResponseActiveCrsXss xss)
        {
            this.Gen = gen ?? throw new global::System.ArgumentNullException(nameof(gen));
            this.Java = java ?? throw new global::System.ArgumentNullException(nameof(java));
            this.Lfi = lfi ?? throw new global::System.ArgumentNullException(nameof(lfi));
            this.Ma = ma ?? throw new global::System.ArgumentNullException(nameof(ma));
            this.Php = php ?? throw new global::System.ArgumentNullException(nameof(php));
            this.Rce = rce ?? throw new global::System.ArgumentNullException(nameof(rce));
            this.Rfi = rfi ?? throw new global::System.ArgumentNullException(nameof(rfi));
            this.Sd = sd ?? throw new global::System.ArgumentNullException(nameof(sd));
            this.Sf = sf ?? throw new global::System.ArgumentNullException(nameof(sf));
            this.Sqli = sqli ?? throw new global::System.ArgumentNullException(nameof(sqli));
            this.Xss = xss ?? throw new global::System.ArgumentNullException(nameof(xss));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveCrs" /> class.
        /// </summary>
        public PutFirewallConfigResponseActiveCrs()
        {
        }

    }
}