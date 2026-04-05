
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1RouteVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Continue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middleware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Middleware { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1RouteVariant3" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="continue"></param>
        /// <param name="middleware"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1RouteVariant3(
            string src,
            bool @continue,
            double middleware)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Continue = @continue;
            this.Middleware = middleware;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1RouteVariant3" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1RouteVariant3()
        {
        }
    }
}