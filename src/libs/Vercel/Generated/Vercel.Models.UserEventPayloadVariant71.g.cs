
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant71
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldTeam")]
        public global::Vercel.UserEventPayloadVariant71OldTeam? OldTeam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newTeam")]
        public global::Vercel.UserEventPayloadVariant71NewTeam? NewTeam { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant71" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="oldTeam"></param>
        /// <param name="newTeam"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant71(
            string url,
            global::Vercel.UserEventPayloadVariant71OldTeam? oldTeam,
            global::Vercel.UserEventPayloadVariant71NewTeam? newTeam)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.OldTeam = oldTeam;
            this.NewTeam = newTeam;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant71" /> class.
        /// </summary>
        public UserEventPayloadVariant71()
        {
        }
    }
}