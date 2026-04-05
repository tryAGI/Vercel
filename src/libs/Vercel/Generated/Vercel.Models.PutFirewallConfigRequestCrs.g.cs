
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Custom Ruleset
    /// </summary>
    public sealed partial class PutFirewallConfigRequestCrs
    {
        /// <summary>
        /// Scanner Detection - Detect and prevent reconnaissance activities from network scanning tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd")]
        public global::Vercel.PutFirewallConfigRequestCrsSd? Sd { get; set; }

        /// <summary>
        /// Multipart Attack - Block attempts to bypass security controls using multipart/form-data encoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ma")]
        public global::Vercel.PutFirewallConfigRequestCrsMa? Ma { get; set; }

        /// <summary>
        /// Local File Inclusion Attack - Prevent unauthorized access to local files through web applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfi")]
        public global::Vercel.PutFirewallConfigRequestCrsLfi? Lfi { get; set; }

        /// <summary>
        /// Remote File Inclusion Attack - Prohibit unauthorized upload or execution of remote files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rfi")]
        public global::Vercel.PutFirewallConfigRequestCrsRfi? Rfi { get; set; }

        /// <summary>
        /// Remote Execution Attack - Prevent unauthorized execution of remote scripts or commands.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rce")]
        public global::Vercel.PutFirewallConfigRequestCrsRce? Rce { get; set; }

        /// <summary>
        /// PHP Attack - Safeguard against vulnerability exploits in PHP-based applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("php")]
        public global::Vercel.PutFirewallConfigRequestCrsPhp? Php { get; set; }

        /// <summary>
        /// Generic Attack - Provide broad protection from various undefined or novel attack vectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gen")]
        public global::Vercel.PutFirewallConfigRequestCrsGen? Gen { get; set; }

        /// <summary>
        /// XSS Attack - Prevent injection of malicious scripts into trusted webpages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xss")]
        public global::Vercel.PutFirewallConfigRequestCrsXss? Xss { get; set; }

        /// <summary>
        /// SQL Injection Attack - Prohibit unauthorized use of SQL commands to manipulate databases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sqli")]
        public global::Vercel.PutFirewallConfigRequestCrsSqli? Sqli { get; set; }

        /// <summary>
        /// Session Fixation Attack - Prevent unauthorized takeover of user sessions by enforcing unique session IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sf")]
        public global::Vercel.PutFirewallConfigRequestCrsSf? Sf { get; set; }

        /// <summary>
        /// Java Attack - Mitigate risks of exploitation targeting Java-based applications or components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("java")]
        public global::Vercel.PutFirewallConfigRequestCrsJava? Java { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestCrs" /> class.
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
        public PutFirewallConfigRequestCrs(
            global::Vercel.PutFirewallConfigRequestCrsSd? sd,
            global::Vercel.PutFirewallConfigRequestCrsMa? ma,
            global::Vercel.PutFirewallConfigRequestCrsLfi? lfi,
            global::Vercel.PutFirewallConfigRequestCrsRfi? rfi,
            global::Vercel.PutFirewallConfigRequestCrsRce? rce,
            global::Vercel.PutFirewallConfigRequestCrsPhp? php,
            global::Vercel.PutFirewallConfigRequestCrsGen? gen,
            global::Vercel.PutFirewallConfigRequestCrsXss? xss,
            global::Vercel.PutFirewallConfigRequestCrsSqli? sqli,
            global::Vercel.PutFirewallConfigRequestCrsSf? sf,
            global::Vercel.PutFirewallConfigRequestCrsJava? java)
        {
            this.Sd = sd;
            this.Ma = ma;
            this.Lfi = lfi;
            this.Rfi = rfi;
            this.Rce = rce;
            this.Php = php;
            this.Gen = gen;
            this.Xss = xss;
            this.Sqli = sqli;
            this.Sf = sf;
            this.Java = java;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestCrs" /> class.
        /// </summary>
        public PutFirewallConfigRequestCrs()
        {
        }
    }
}