
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set when a Vercel App or Integration acts on behalf of a {@link User}. Captures user-consented OAuth delegation that the ACL layer may inspect to evaluate scope restrictions. This is NOT for impersonation or token-exchange provenance — those live on `auth.token`, not on the principal.
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1TypeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1App App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1(
            global::Vercel.GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1App app,
            global::Vercel.GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1Type type)
        {
            this.Type = type;
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1()
        {
        }

    }
}