
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Complete replacement set of trigger destinations.
    /// </summary>
    public sealed partial class ConnectReplaceTriggerDestinationsRequest
    {
        /// <summary>
        /// Complete replacement set of trigger destinations. An empty array removes all destinations. Connector get and list responses expose the saved set as triggerDestinations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ConnectTriggerDestinationInput> Destinations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectReplaceTriggerDestinationsRequest" /> class.
        /// </summary>
        /// <param name="destinations">
        /// Complete replacement set of trigger destinations. An empty array removes all destinations. Connector get and list responses expose the saved set as triggerDestinations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectReplaceTriggerDestinationsRequest(
            global::System.Collections.Generic.IList<global::Vercel.ConnectTriggerDestinationInput> destinations)
        {
            this.Destinations = destinations ?? throw new global::System.ArgumentNullException(nameof(destinations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectReplaceTriggerDestinationsRequest" /> class.
        /// </summary>
        public ConnectReplaceTriggerDestinationsRequest()
        {
        }

    }
}