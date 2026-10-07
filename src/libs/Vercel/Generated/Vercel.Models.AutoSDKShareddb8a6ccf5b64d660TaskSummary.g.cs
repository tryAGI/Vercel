
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareddb8a6ccf5b64d660TaskSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Pending { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Succeeded { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareddb8a6ccf5b64d660TaskSummary" /> class.
        /// </summary>
        /// <param name="failed"></param>
        /// <param name="pending"></param>
        /// <param name="succeeded"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareddb8a6ccf5b64d660TaskSummary(
            double failed,
            double pending,
            double succeeded,
            double total)
        {
            this.Failed = failed;
            this.Pending = pending;
            this.Succeeded = succeeded;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareddb8a6ccf5b64d660TaskSummary" /> class.
        /// </summary>
        public AutoSDKShareddb8a6ccf5b64d660TaskSummary()
        {
        }

    }
}