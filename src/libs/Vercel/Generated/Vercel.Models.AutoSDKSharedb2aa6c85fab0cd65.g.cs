
#nullable enable

namespace Vercel
{
    /// <summary>
    /// projectIds are added when the config is uploaded to s3 deployment assets.
    /// </summary>
    public sealed partial class AutoSDKSharedb2aa6c85fab0cd65
    {
        /// <summary>
        /// See https://openapi.vercel.sh/microfrontends.json.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$schema")]
        public string? x_schema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared30685e6067cce163> Applications { get; set; }

        /// <summary>
        /// Optional configuration options for the microfrontend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Options? Options { get; set; }

        /// <summary>
        /// The version of the microfrontends config schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedb2aa6c85fab0cd65VersionJsonConverter))]
        public global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Version? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb2aa6c85fab0cd65" /> class.
        /// </summary>
        /// <param name="applications"></param>
        /// <param name="x_schema">
        /// See https://openapi.vercel.sh/microfrontends.json.
        /// </param>
        /// <param name="options">
        /// Optional configuration options for the microfrontend.
        /// </param>
        /// <param name="version">
        /// The version of the microfrontends config schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb2aa6c85fab0cd65(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared30685e6067cce163> applications,
            string? x_schema,
            global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Options? options,
            global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Version? version)
        {
            this.x_schema = x_schema;
            this.Applications = applications ?? throw new global::System.ArgumentNullException(nameof(applications));
            this.Options = options;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb2aa6c85fab0cd65" /> class.
        /// </summary>
        public AutoSDKSharedb2aa6c85fab0cd65()
        {
        }

    }
}