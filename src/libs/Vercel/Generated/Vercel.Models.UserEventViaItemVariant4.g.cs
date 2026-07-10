
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata for {@link viaIds}.
    /// </summary>
    public sealed partial class UserEventViaItemVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventViaItemVariant4TypeJsonConverter))]
        public global::Vercel.UserEventViaItemVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventViaItemVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventViaItemVariant4(
            global::Vercel.UserEventViaItemVariant4Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventViaItemVariant4" /> class.
        /// </summary>
        public UserEventViaItemVariant4()
        {
        }

    }
}