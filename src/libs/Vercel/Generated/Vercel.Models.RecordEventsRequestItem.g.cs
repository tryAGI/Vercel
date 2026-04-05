
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecordEventsRequestItem
    {
        /// <summary>
        /// A UUID (universally unique identifer) for the session that generated this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// One of `LOCAL` or `REMOTE`. `LOCAL` specifies that the cache event was from the user's filesystem cache. `REMOTE` specifies that the cache event is from a remote cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.RecordEventsRequestItemSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.RecordEventsRequestItemSource Source { get; set; }

        /// <summary>
        /// One of `HIT` or `MISS`. `HIT` specifies that a cached artifact for `hash` was found in the cache. `MISS` specifies that a cached artifact with `hash` was not found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.RecordEventsRequestItemEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.RecordEventsRequestItemEvent Event { get; set; }

        /// <summary>
        /// The artifact hash<br/>
        /// Example: 12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </summary>
        /// <example>12HKQaOmR5t5Uy6vdcQsNIiZgHGB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        /// The time taken to generate the artifact. This should be sent as a body parameter on `HIT` events.<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordEventsRequestItem" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// A UUID (universally unique identifer) for the session that generated this event.
        /// </param>
        /// <param name="source">
        /// One of `LOCAL` or `REMOTE`. `LOCAL` specifies that the cache event was from the user's filesystem cache. `REMOTE` specifies that the cache event is from a remote cache.
        /// </param>
        /// <param name="event">
        /// One of `HIT` or `MISS`. `HIT` specifies that a cached artifact for `hash` was found in the cache. `MISS` specifies that a cached artifact with `hash` was not found.
        /// </param>
        /// <param name="hash">
        /// The artifact hash<br/>
        /// Example: 12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="duration">
        /// The time taken to generate the artifact. This should be sent as a body parameter on `HIT` events.<br/>
        /// Example: 400
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordEventsRequestItem(
            string sessionId,
            global::Vercel.RecordEventsRequestItemSource source,
            global::Vercel.RecordEventsRequestItemEvent @event,
            string hash,
            double? duration)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Source = source;
            this.Event = @event;
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordEventsRequestItem" /> class.
        /// </summary>
        public RecordEventsRequestItem()
        {
        }
    }
}