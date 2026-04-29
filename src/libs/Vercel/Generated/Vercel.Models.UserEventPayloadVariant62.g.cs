
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant62
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant62Team Team { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant62Configuration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant62" /> class.
        /// </summary>
        /// <param name="team"></param>
        /// <param name="configuration"></param>
        /// <param name="newName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant62(
            global::Vercel.UserEventPayloadVariant62Team team,
            global::Vercel.UserEventPayloadVariant62Configuration configuration,
            string newName)
        {
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant62" /> class.
        /// </summary>
        public UserEventPayloadVariant62()
        {
        }
    }
}