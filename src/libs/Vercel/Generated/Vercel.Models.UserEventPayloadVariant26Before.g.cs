
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant26Before
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.UserEventPayloadVariant26BeforeResources? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant26BeforePermission>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant26Before" /> class.
        /// </summary>
        /// <param name="resources"></param>
        /// <param name="permissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant26Before(
            global::Vercel.UserEventPayloadVariant26BeforeResources? resources,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant26BeforePermission>? permissions)
        {
            this.Resources = resources;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant26Before" /> class.
        /// </summary>
        public UserEventPayloadVariant26Before()
        {
        }
    }
}