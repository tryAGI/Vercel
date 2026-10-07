
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Caller-side bindings to other services.
    /// </summary>
    public sealed partial class AutoSDKShared50df233f8638e1faBinding
    {
        /// <summary>
        /// Environment variable name that will store the generated value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Env { get; set; }

        /// <summary>
        /// Generated value shape, must be `"url"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared50df233f8638e1faBindingFormatJsonConverter))]
        public global::Vercel.AutoSDKShared50df233f8638e1faBindingFormat Format { get; set; }

        /// <summary>
        /// Target service name from `services`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// If present, must be `"service"` for Service-to-Service HTTP bindings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared50df233f8638e1faBindingTypeJsonConverter))]
        public global::Vercel.AutoSDKShared50df233f8638e1faBindingType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared50df233f8638e1faBinding" /> class.
        /// </summary>
        /// <param name="env">
        /// Environment variable name that will store the generated value
        /// </param>
        /// <param name="service">
        /// Target service name from `services`.
        /// </param>
        /// <param name="format">
        /// Generated value shape, must be `"url"`.
        /// </param>
        /// <param name="type">
        /// If present, must be `"service"` for Service-to-Service HTTP bindings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared50df233f8638e1faBinding(
            string env,
            string service,
            global::Vercel.AutoSDKShared50df233f8638e1faBindingFormat format,
            global::Vercel.AutoSDKShared50df233f8638e1faBindingType? type)
        {
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
            this.Format = format;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared50df233f8638e1faBinding" /> class.
        /// </summary>
        public AutoSDKShared50df233f8638e1faBinding()
        {
        }

    }
}