
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Feature blocks for the user
    /// </summary>
    public sealed partial class AuthUserFeatureBlocks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.AuthUserFeatureBlocksWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserFeatureBlocks" /> class.
        /// </summary>
        /// <param name="webAnalytics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserFeatureBlocks(
            global::Vercel.AuthUserFeatureBlocksWebAnalytics? webAnalytics)
        {
            this.WebAnalytics = webAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserFeatureBlocks" /> class.
        /// </summary>
        public AuthUserFeatureBlocks()
        {
        }
    }
}