
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The results of the check Run
    /// </summary>
    public sealed partial class UpdateCheckRequestOutput
    {
        /// <summary>
        /// Metrics about the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::Vercel.UpdateCheckRequestOutputMetrics? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutput" /> class.
        /// </summary>
        /// <param name="metrics">
        /// Metrics about the page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCheckRequestOutput(
            global::Vercel.UpdateCheckRequestOutputMetrics? metrics)
        {
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutput" /> class.
        /// </summary>
        public UpdateCheckRequestOutput()
        {
        }
    }
}