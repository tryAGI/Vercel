
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant21
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldTeam")]
        public global::Vercel.UserEventPayloadVariant21OldTeam? OldTeam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newTeam")]
        public global::Vercel.UserEventPayloadVariant21NewTeam? NewTeam { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant21" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="name"></param>
        /// <param name="oldTeam"></param>
        /// <param name="newTeam"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant21(
            string alias,
            string? name,
            global::Vercel.UserEventPayloadVariant21OldTeam? oldTeam,
            global::Vercel.UserEventPayloadVariant21NewTeam? newTeam)
        {
            this.Name = name;
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.OldTeam = oldTeam;
            this.NewTeam = newTeam;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant21" /> class.
        /// </summary>
        public UserEventPayloadVariant21()
        {
        }
    }
}