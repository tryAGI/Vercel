
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant196OptionsAllowlist
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant196OptionsAllowlistPath> Paths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant196OptionsAllowlist" /> class.
        /// </summary>
        /// <param name="paths"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant196OptionsAllowlist(
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant196OptionsAllowlistPath> paths)
        {
            this.Paths = paths ?? throw new global::System.ArgumentNullException(nameof(paths));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant196OptionsAllowlist" /> class.
        /// </summary>
        public UserEventPayloadVariant196OptionsAllowlist()
        {
        }
    }
}