
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Caller-side bindings to other services.
    /// </summary>
    public sealed partial class CancelDeploymentResponseServiceVariant2Binding
    {
        /// <summary>
        /// Must be `"service"` for Service-to-Service HTTP bindings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseServiceVariant2BindingTypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseServiceVariant2BindingType Type { get; set; }

        /// <summary>
        /// Target service name from `experimentalServicesV2`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// Generated value shape, must be `"url"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseServiceVariant2BindingFormatJsonConverter))]
        public global::Vercel.CancelDeploymentResponseServiceVariant2BindingFormat Format { get; set; }

        /// <summary>
        /// Environment variable name that will store the generated value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2Binding" /> class.
        /// </summary>
        /// <param name="service">
        /// Target service name from `experimentalServicesV2`.
        /// </param>
        /// <param name="env">
        /// Environment variable name that will store the generated value
        /// </param>
        /// <param name="type">
        /// Must be `"service"` for Service-to-Service HTTP bindings.
        /// </param>
        /// <param name="format">
        /// Generated value shape, must be `"url"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseServiceVariant2Binding(
            string service,
            string env,
            global::Vercel.CancelDeploymentResponseServiceVariant2BindingType type,
            global::Vercel.CancelDeploymentResponseServiceVariant2BindingFormat format)
        {
            this.Type = type;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Format = format;
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2Binding" /> class.
        /// </summary>
        public CancelDeploymentResponseServiceVariant2Binding()
        {
        }

    }
}