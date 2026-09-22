
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared7e5cde0fd7c87b94Crs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsGen Gen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("java")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsJava Java { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsLfi Lfi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ma")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsMa Ma { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("php")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsPhp Php { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsRce Rce { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsRfi Rfi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsSd Sd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsSf Sf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sqli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsSqli Sqli { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsXss Xss { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared7e5cde0fd7c87b94Crs" /> class.
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
        public AutoSDKShared7e5cde0fd7c87b94Crs(
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsGen gen,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsJava java,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsLfi lfi,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsMa ma,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsPhp php,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsRce rce,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsRfi rfi,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsSd sd,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsSf sf,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsSqli sqli,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsXss xss)
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
        /// Initializes a new instance of the <see cref="AutoSDKShared7e5cde0fd7c87b94Crs" /> class.
        /// </summary>
        public AutoSDKShared7e5cde0fd7c87b94Crs()
        {
        }

    }
}