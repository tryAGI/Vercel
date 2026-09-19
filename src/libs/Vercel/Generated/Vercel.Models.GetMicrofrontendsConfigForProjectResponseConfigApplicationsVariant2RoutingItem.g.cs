
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Groups of path expressions that are routed to this application. See https://vercel.com/docs/microfrontends/path-routing.
    /// </summary>
    public sealed partial class GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant2RoutingItem
    {
        /// <summary>
        /// The name of the feature flag that controls routing for this group of paths. See https://vercel.com/docs/microfrontends/path-routing#routing-changes-safely-with-flags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        public string? Flag { get; set; }

        /// <summary>
        /// Group name for the paths.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// A list of path expressions that are routed to this application. See https://vercel.com/docs/microfrontends/path-routing#supported-path-expressions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant2RoutingItem" /> class.
        /// </summary>
        /// <param name="paths">
        /// A list of path expressions that are routed to this application. See https://vercel.com/docs/microfrontends/path-routing#supported-path-expressions.
        /// </param>
        /// <param name="flag">
        /// The name of the feature flag that controls routing for this group of paths. See https://vercel.com/docs/microfrontends/path-routing#routing-changes-safely-with-flags.
        /// </param>
        /// <param name="group">
        /// Group name for the paths.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant2RoutingItem(
            global::System.Collections.Generic.IList<string> paths,
            string? flag,
            string? group)
        {
            this.Flag = flag;
            this.Group = group;
            this.Paths = paths ?? throw new global::System.ArgumentNullException(nameof(paths));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant2RoutingItem" /> class.
        /// </summary>
        public GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant2RoutingItem()
        {
        }

    }
}