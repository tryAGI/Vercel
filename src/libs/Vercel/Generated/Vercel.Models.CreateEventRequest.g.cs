
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEventRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateEventRequestEventVariant1, global::Vercel.CreateEventRequestEventVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.CreateEventRequestEventVariant1, global::Vercel.CreateEventRequestEventVariant2> Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventRequest" /> class.
        /// </summary>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEventRequest(
            global::Vercel.OneOf<global::Vercel.CreateEventRequestEventVariant1, global::Vercel.CreateEventRequestEventVariant2> @event)
        {
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventRequest" /> class.
        /// </summary>
        public CreateEventRequest()
        {
        }
    }
}