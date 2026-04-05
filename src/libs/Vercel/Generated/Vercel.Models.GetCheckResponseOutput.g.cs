
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCheckResponseOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::Vercel.GetCheckResponseOutputMetrics? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckResponseOutput" /> class.
        /// </summary>
        /// <param name="metrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCheckResponseOutput(
            global::Vercel.GetCheckResponseOutputMetrics? metrics)
        {
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckResponseOutput" /> class.
        /// </summary>
        public GetCheckResponseOutput()
        {
        }
    }
}