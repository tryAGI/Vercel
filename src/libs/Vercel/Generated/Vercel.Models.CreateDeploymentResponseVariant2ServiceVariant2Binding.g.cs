
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Caller-side bindings to other services.
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2ServiceVariant2Binding
    {
        /// <summary>
        /// Must be `"service"` for Service-to-Service HTTP bindings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ServiceVariant2BindingTypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2BindingType Type { get; set; }

        /// <summary>
        /// Target service name from `services`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// Generated value shape, must be `"url"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ServiceVariant2BindingFormatJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2BindingFormat Format { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant2Binding" /> class.
        /// </summary>
        /// <param name="service">
        /// Target service name from `services`.
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
        public CreateDeploymentResponseVariant2ServiceVariant2Binding(
            string service,
            string env,
            global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2BindingType type,
            global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2BindingFormat format)
        {
            this.Type = type;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Format = format;
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant2Binding" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2ServiceVariant2Binding()
        {
        }

    }
}