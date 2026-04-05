
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1RouteVariant1Locale
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::System.Collections.Generic.Dictionary<string, string>? Redirect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cookie")]
        public string? Cookie { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1RouteVariant1Locale" /> class.
        /// </summary>
        /// <param name="redirect"></param>
        /// <param name="cookie"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1RouteVariant1Locale(
            global::System.Collections.Generic.Dictionary<string, string>? redirect,
            string? cookie)
        {
            this.Redirect = redirect;
            this.Cookie = cookie;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1RouteVariant1Locale" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1RouteVariant1Locale()
        {
        }
    }
}