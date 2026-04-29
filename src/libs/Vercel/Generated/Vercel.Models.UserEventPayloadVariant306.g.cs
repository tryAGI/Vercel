
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant306
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant306Team Team { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant306Configuration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peering")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant306Peering Peering { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant306" /> class.
        /// </summary>
        /// <param name="team"></param>
        /// <param name="configuration"></param>
        /// <param name="peering"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant306(
            global::Vercel.UserEventPayloadVariant306Team team,
            global::Vercel.UserEventPayloadVariant306Configuration configuration,
            global::Vercel.UserEventPayloadVariant306Peering peering)
        {
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Peering = peering ?? throw new global::System.ArgumentNullException(nameof(peering));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant306" /> class.
        /// </summary>
        public UserEventPayloadVariant306()
        {
        }
    }
}