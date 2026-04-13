
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant129PrevProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontends")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant129PrevProjectMicrofrontendsVariant1, global::Vercel.UserEventPayloadVariant129PrevProjectMicrofrontendsVariant2, global::Vercel.UserEventPayloadVariant129PrevProjectMicrofrontendsVariant3>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant129PrevProjectMicrofrontendsVariant1, global::Vercel.UserEventPayloadVariant129PrevProjectMicrofrontendsVariant2, global::Vercel.UserEventPayloadVariant129PrevProjectMicrofrontendsVariant3>? Microfrontends { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant129PrevProject" /> class.
        /// </summary>
        /// <param name="microfrontends"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant129PrevProject(
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant129PrevProjectMicrofrontendsVariant1, global::Vercel.UserEventPayloadVariant129PrevProjectMicrofrontendsVariant2, global::Vercel.UserEventPayloadVariant129PrevProjectMicrofrontendsVariant3>? microfrontends)
        {
            this.Microfrontends = microfrontends;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant129PrevProject" /> class.
        /// </summary>
        public UserEventPayloadVariant129PrevProject()
        {
        }
    }
}