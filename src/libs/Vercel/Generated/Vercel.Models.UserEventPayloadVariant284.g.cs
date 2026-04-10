
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant284
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant284Team Team { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant284Configuration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peering")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant284Peering Peering { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newName")]
        public string? NewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant284" /> class.
        /// </summary>
        /// <param name="team"></param>
        /// <param name="configuration"></param>
        /// <param name="peering"></param>
        /// <param name="newName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant284(
            global::Vercel.UserEventPayloadVariant284Team team,
            global::Vercel.UserEventPayloadVariant284Configuration configuration,
            global::Vercel.UserEventPayloadVariant284Peering peering,
            string? newName)
        {
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Peering = peering ?? throw new global::System.ArgumentNullException(nameof(peering));
            this.NewName = newName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant284" /> class.
        /// </summary>
        public UserEventPayloadVariant284()
        {
        }
    }
}