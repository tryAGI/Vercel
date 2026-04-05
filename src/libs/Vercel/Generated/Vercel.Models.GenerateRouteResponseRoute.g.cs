
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteResponseRoute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathCondition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GenerateRouteResponseRoutePathCondition PathCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteCondition>? Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteAction> Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteResponseRoute" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="pathCondition"></param>
        /// <param name="actions"></param>
        /// <param name="conditions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteResponseRoute(
            string name,
            string description,
            global::Vercel.GenerateRouteResponseRoutePathCondition pathCondition,
            global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteAction> actions,
            global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteCondition>? conditions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PathCondition = pathCondition ?? throw new global::System.ArgumentNullException(nameof(pathCondition));
            this.Conditions = conditions;
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteResponseRoute" /> class.
        /// </summary>
        public GenerateRouteResponseRoute()
        {
        }
    }
}