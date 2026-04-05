
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The microfrontends for the alias including the routing configuration
    /// </summary>
    public sealed partial class GetAliasResponseMicrofrontends
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultApp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetAliasResponseMicrofrontendsDefaultApp DefaultApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applications")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant2Item>, global::System.Collections.Generic.IList<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant3Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant2Item>, global::System.Collections.Generic.IList<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant3Item>> Applications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAliasResponseMicrofrontends" /> class.
        /// </summary>
        /// <param name="defaultApp"></param>
        /// <param name="applications"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAliasResponseMicrofrontends(
            global::Vercel.GetAliasResponseMicrofrontendsDefaultApp defaultApp,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant2Item>, global::System.Collections.Generic.IList<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant3Item>> applications)
        {
            this.DefaultApp = defaultApp ?? throw new global::System.ArgumentNullException(nameof(defaultApp));
            this.Applications = applications;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAliasResponseMicrofrontends" /> class.
        /// </summary>
        public GetAliasResponseMicrofrontends()
        {
        }
    }
}