
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddRouteResponseRouteRouteLocale
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cookie")]
        public string? Cookie { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::System.Collections.Generic.Dictionary<string, string>? Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRouteResponseRouteRouteLocale" /> class.
        /// </summary>
        /// <param name="cookie"></param>
        /// <param name="redirect"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddRouteResponseRouteRouteLocale(
            string? cookie,
            global::System.Collections.Generic.Dictionary<string, string>? redirect)
        {
            this.Cookie = cookie;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRouteResponseRouteRouteLocale" /> class.
        /// </summary>
        public AddRouteResponseRouteRouteLocale()
        {
        }

    }
}