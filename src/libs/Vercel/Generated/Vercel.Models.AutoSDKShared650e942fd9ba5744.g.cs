
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared650e942fd9ba5744
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedcac2d258b36c4083JsonConverter))]
        public global::Vercel.AutoSDKSharedcac2d258b36c4083? Allow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subnets")]
        public global::Vercel.AutoSDKShared650e942fd9ba5744Subnets? Subnets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared650e942fd9ba5744" /> class.
        /// </summary>
        /// <param name="allow"></param>
        /// <param name="subnets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared650e942fd9ba5744(
            global::Vercel.AutoSDKSharedcac2d258b36c4083? allow,
            global::Vercel.AutoSDKShared650e942fd9ba5744Subnets? subnets)
        {
            this.Allow = allow;
            this.Subnets = subnets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared650e942fd9ba5744" /> class.
        /// </summary>
        public AutoSDKShared650e942fd9ba5744()
        {
        }

    }
}