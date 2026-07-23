
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1Anonymous
    {
        /// <summary>
        /// When the anonymous project and its token expire, in milliseconds.<br/>
        /// Example: 1753120000000L
        /// </summary>
        /// <example>1753120000000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1Anonymous" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// When the anonymous project and its token expire, in milliseconds.<br/>
        /// Example: 1753120000000L
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1Anonymous(
            double expiresAt)
        {
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1Anonymous" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1Anonymous()
        {
        }

    }
}