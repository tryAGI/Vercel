
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared6ed60ada20c5170aCrs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsGen Gen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("java")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsJava Java { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsLfi Lfi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ma")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsMa Ma { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("php")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsPhp Php { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsRce Rce { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rfi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsRfi Rfi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsSd Sd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsSf Sf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sqli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsSqli Sqli { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed60ada20c5170aCrsXss Xss { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6ed60ada20c5170aCrs" /> class.
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
        public AutoSDKShared6ed60ada20c5170aCrs(
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsGen gen,
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsJava java,
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsLfi lfi,
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsMa ma,
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsPhp php,
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsRce rce,
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsRfi rfi,
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsSd sd,
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsSf sf,
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsSqli sqli,
            global::Vercel.AutoSDKShared6ed60ada20c5170aCrsXss xss)
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
        /// Initializes a new instance of the <see cref="AutoSDKShared6ed60ada20c5170aCrs" /> class.
        /// </summary>
        public AutoSDKShared6ed60ada20c5170aCrs()
        {
        }

    }
}