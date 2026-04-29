
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant34Before
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.UserEventPayloadVariant34BeforeResources? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant34BeforePermission>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant34Before" /> class.
        /// </summary>
        /// <param name="resources"></param>
        /// <param name="permissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant34Before(
            global::Vercel.UserEventPayloadVariant34BeforeResources? resources,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant34BeforePermission>? permissions)
        {
            this.Resources = resources;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant34Before" /> class.
        /// </summary>
        public UserEventPayloadVariant34Before()
        {
        }
    }
}