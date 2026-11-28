
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignFlagOverridesRequest
    {
        /// <summary>
        /// The value of each overridden flag, by flag key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Overrides { get; set; }

        /// <summary>
        /// production, preview, development or the slug of a custom environment. Defaults to the environment of a Vercel OIDC token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Seconds until the overrides expire. Defaults to one hour, at most one day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public int? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignFlagOverridesRequest" /> class.
        /// </summary>
        /// <param name="overrides">
        /// The value of each overridden flag, by flag key
        /// </param>
        /// <param name="environment">
        /// production, preview, development or the slug of a custom environment. Defaults to the environment of a Vercel OIDC token.
        /// </param>
        /// <param name="ttl">
        /// Seconds until the overrides expire. Defaults to one hour, at most one day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignFlagOverridesRequest(
            object overrides,
            string? environment,
            int? ttl)
        {
            this.Overrides = overrides ?? throw new global::System.ArgumentNullException(nameof(overrides));
            this.Environment = environment;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignFlagOverridesRequest" /> class.
        /// </summary>
        public SignFlagOverridesRequest()
        {
        }

    }
}