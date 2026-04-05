
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentRoute")]
        public global::Vercel.GenerateRouteRequestCurrentRoute? CurrentRoute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="currentRoute"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteRequest(
            string prompt,
            global::Vercel.GenerateRouteRequestCurrentRoute? currentRoute)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.CurrentRoute = currentRoute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequest" /> class.
        /// </summary>
        public GenerateRouteRequest()
        {
        }
    }
}