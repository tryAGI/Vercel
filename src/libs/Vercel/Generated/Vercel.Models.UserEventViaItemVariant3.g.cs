
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata for {@link viaIds}.
    /// </summary>
    public sealed partial class UserEventViaItemVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventViaItemVariant3TypeJsonConverter))]
        public global::Vercel.UserEventViaItemVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventViaItemVariant3" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventViaItemVariant3(
            global::Vercel.UserEventViaItemVariant3Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventViaItemVariant3" /> class.
        /// </summary>
        public UserEventViaItemVariant3()
        {
        }
    }
}