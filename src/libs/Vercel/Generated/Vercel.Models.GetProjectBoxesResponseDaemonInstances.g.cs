
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemonInstances
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Desired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectBoxesResponseDaemonInstancesItem> Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Ready { get; set; }

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
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonInstances" /> class.
        /// </summary>
        /// <param name="desired"></param>
        /// <param name="items"></param>
        /// <param name="ready"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemonInstances(
            double desired,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectBoxesResponseDaemonInstancesItem> items,
            double ready,
            double total)
        {
            this.Desired = desired;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Ready = ready;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonInstances" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemonInstances()
        {
        }

    }
}