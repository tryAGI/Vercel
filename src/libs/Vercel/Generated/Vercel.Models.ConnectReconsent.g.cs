
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Existing authorizations no longer cover the connector's configured scopes, so they must be re-authorized.
    /// </summary>
    public sealed partial class ConnectReconsent
    {
        /// <summary>
        /// The affected authorization scope. user means each affected user must authorize again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectReconsentScopeJsonConverter))]
        public global::Vercel.ConnectReconsentScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectReconsent" /> class.
        /// </summary>
        /// <param name="scope">
        /// The affected authorization scope. user means each affected user must authorize again.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectReconsent(
            global::Vercel.ConnectReconsentScope scope)
        {
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectReconsent" /> class.
        /// </summary>
        public ConnectReconsent()
        {
        }

    }
}