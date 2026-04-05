
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant127PrevProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontends")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant127PrevProjectMicrofrontendsVariant1, global::Vercel.UserEventPayloadVariant127PrevProjectMicrofrontendsVariant2, global::Vercel.UserEventPayloadVariant127PrevProjectMicrofrontendsVariant3>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant127PrevProjectMicrofrontendsVariant1, global::Vercel.UserEventPayloadVariant127PrevProjectMicrofrontendsVariant2, global::Vercel.UserEventPayloadVariant127PrevProjectMicrofrontendsVariant3>? Microfrontends { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant127PrevProject" /> class.
        /// </summary>
        /// <param name="microfrontends"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant127PrevProject(
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant127PrevProjectMicrofrontendsVariant1, global::Vercel.UserEventPayloadVariant127PrevProjectMicrofrontendsVariant2, global::Vercel.UserEventPayloadVariant127PrevProjectMicrofrontendsVariant3>? microfrontends)
        {
            this.Microfrontends = microfrontends;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant127PrevProject" /> class.
        /// </summary>
        public UserEventPayloadVariant127PrevProject()
        {
        }
    }
}