
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedb4cb9cbf2561e851Crs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsGen Gen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("java")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsJava Java { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsLfi Lfi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ma")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsMa Ma { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("php")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsPhp Php { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsRce Rce { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsRfi Rfi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsSd Sd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsSf Sf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sqli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsSqli Sqli { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsXss Xss { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb4cb9cbf2561e851Crs" /> class.
        /// </summary>
        /// <param name="gen"></param>
        /// <param name="java"></param>
        /// <param name="lfi"></param>
        /// <param name="ma"></param>
        /// <param name="php"></param>
        /// <param name="rce"></param>
        /// <param name="rfi"></param>
        /// <param name="sd"></param>
        /// <param name="sf"></param>
        /// <param name="sqli"></param>
        /// <param name="xss"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb4cb9cbf2561e851Crs(
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsGen gen,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsJava java,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsLfi lfi,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsMa ma,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsPhp php,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsRce rce,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsRfi rfi,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsSd sd,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsSf sf,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsSqli sqli,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851CrsXss xss)
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
        /// Initializes a new instance of the <see cref="AutoSDKSharedb4cb9cbf2561e851Crs" /> class.
        /// </summary>
        public AutoSDKSharedb4cb9cbf2561e851Crs()
        {
        }

    }
}