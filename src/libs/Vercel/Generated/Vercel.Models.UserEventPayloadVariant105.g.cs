
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant105
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldEnvVar")]
        public global::Vercel.UserEventPayloadVariant105OldEnvVar? OldEnvVar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newEnvVar")]
        public global::Vercel.UserEventPayloadVariant105NewEnvVar? NewEnvVar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateDiff")]
        public global::Vercel.UserEventPayloadVariant105UpdateDiff? UpdateDiff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant105" /> class.
        /// </summary>
        /// <param name="oldEnvVar"></param>
        /// <param name="newEnvVar"></param>
        /// <param name="updateDiff"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant105(
            global::Vercel.UserEventPayloadVariant105OldEnvVar? oldEnvVar,
            global::Vercel.UserEventPayloadVariant105NewEnvVar? newEnvVar,
            global::Vercel.UserEventPayloadVariant105UpdateDiff? updateDiff)
        {
            this.OldEnvVar = oldEnvVar;
            this.NewEnvVar = newEnvVar;
            this.UpdateDiff = updateDiff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant105" /> class.
        /// </summary>
        public UserEventPayloadVariant105()
        {
        }
    }
}