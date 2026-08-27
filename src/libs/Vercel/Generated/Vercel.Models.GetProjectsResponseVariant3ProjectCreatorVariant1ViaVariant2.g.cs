
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set when a Vercel App or Integration acts on behalf of a {@link User}. Captures user-consented OAuth delegation that the ACL layer may inspect to evaluate scope restrictions. This is NOT for impersonation or token-exchange provenance — those live on `auth.token`, not on the principal.
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectCreatorVariant1ViaVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectCreatorVariant1ViaVariant2TypeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectCreatorVariant1ViaVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant3ProjectCreatorVariant1ViaVariant2Integration Integration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectCreatorVariant1ViaVariant2" /> class.
        /// </summary>
        /// <param name="integration"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectCreatorVariant1ViaVariant2(
            global::Vercel.GetProjectsResponseVariant3ProjectCreatorVariant1ViaVariant2Integration integration,
            global::Vercel.GetProjectsResponseVariant3ProjectCreatorVariant1ViaVariant2Type type)
        {
            this.Type = type;
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectCreatorVariant1ViaVariant2" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectCreatorVariant1ViaVariant2()
        {
        }

    }
}