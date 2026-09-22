
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A list of "entities" within the event `text`. Useful for enhancing the displayed text with additional styling and links.
    /// </summary>
    public sealed partial class UserEventEntitie
    {
        /// <summary>
        /// The index of where the entity ends within the `text` (non-inclusive).<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// The index of where the entity begins within the `text` (inclusive).<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// The type of entity.<br/>
        /// Example: author
        /// </summary>
        /// <example>author</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventEntitieTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventEntitieType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventEntitie" /> class.
        /// </summary>
        /// <param name="end">
        /// The index of where the entity ends within the `text` (non-inclusive).<br/>
        /// Example: 3
        /// </param>
        /// <param name="start">
        /// The index of where the entity begins within the `text` (inclusive).<br/>
        /// Example: 0
        /// </param>
        /// <param name="type">
        /// The type of entity.<br/>
        /// Example: author
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventEntitie(
            double end,
            double start,
            global::Vercel.UserEventEntitieType type)
        {
            this.End = end;
            this.Start = start;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventEntitie" /> class.
        /// </summary>
        public UserEventEntitie()
        {
        }

    }
}