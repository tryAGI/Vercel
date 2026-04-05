
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteRequestCurrentRoute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathCondition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GenerateRouteRequestCurrentRoutePathCondition PathCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteCondition>? Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteAction> Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequestCurrentRoute" /> class.
        /// </summary>
        /// <param name="pathCondition"></param>
        /// <param name="actions"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="conditions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteRequestCurrentRoute(
            global::Vercel.GenerateRouteRequestCurrentRoutePathCondition pathCondition,
            global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteAction> actions,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteCondition>? conditions)
        {
            this.Name = name;
            this.Description = description;
            this.PathCondition = pathCondition ?? throw new global::System.ArgumentNullException(nameof(pathCondition));
            this.Conditions = conditions;
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequestCurrentRoute" /> class.
        /// </summary>
        public GenerateRouteRequestCurrentRoute()
        {
        }
    }
}