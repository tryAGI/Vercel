
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata for {@link principalId}.
    /// </summary>
    public sealed partial class UserEventPrincipalVariant5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPrincipalVariant5TypeJsonConverter))]
        public global::Vercel.UserEventPrincipalVariant5Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPrincipalVariant5" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPrincipalVariant5(
            global::Vercel.UserEventPrincipalVariant5Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPrincipalVariant5" /> class.
        /// </summary>
        public UserEventPrincipalVariant5()
        {
        }

    }
}