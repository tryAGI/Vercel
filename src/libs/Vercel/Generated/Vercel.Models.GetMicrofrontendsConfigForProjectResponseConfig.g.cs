
#nullable enable

namespace Vercel
{
    /// <summary>
    /// projectIds are added when the config is uploaded to s3 deployment assets.
    /// </summary>
    public sealed partial class GetMicrofrontendsConfigForProjectResponseConfig
    {
        /// <summary>
        /// See https://openapi.vercel.sh/microfrontends.json.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$schema")]
        public string? x_schema { get; set; }

        /// <summary>
        /// The version of the microfrontends config schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMicrofrontendsConfigForProjectResponseConfigVersionJsonConverter))]
        public global::Vercel.GetMicrofrontendsConfigForProjectResponseConfigVersion? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Applications { get; set; }

        /// <summary>
        /// Optional configuration options for the microfrontend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Vercel.GetMicrofrontendsConfigForProjectResponseConfigOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigForProjectResponseConfig" /> class.
        /// </summary>
        /// <param name="applications"></param>
        /// <param name="x_schema">
        /// See https://openapi.vercel.sh/microfrontends.json.
        /// </param>
        /// <param name="version">
        /// The version of the microfrontends config schema.
        /// </param>
        /// <param name="options">
        /// Optional configuration options for the microfrontend.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsConfigForProjectResponseConfig(
            object applications,
            string? x_schema,
            global::Vercel.GetMicrofrontendsConfigForProjectResponseConfigVersion? version,
            global::Vercel.GetMicrofrontendsConfigForProjectResponseConfigOptions? options)
        {
            this.x_schema = x_schema;
            this.Version = version;
            this.Applications = applications ?? throw new global::System.ArgumentNullException(nameof(applications));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigForProjectResponseConfig" /> class.
        /// </summary>
        public GetMicrofrontendsConfigForProjectResponseConfig()
        {
        }
    }
}