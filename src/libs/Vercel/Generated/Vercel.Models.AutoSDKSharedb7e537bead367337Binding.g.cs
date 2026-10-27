
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Caller-side bindings to other services.
    /// </summary>
    public sealed partial class AutoSDKSharedb7e537bead367337Binding
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedb7e537bead367337BindingFormatJsonConverter))]
        public global::Vercel.AutoSDKSharedb7e537bead367337BindingFormat Format { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedb7e537bead367337BindingTypeJsonConverter))]
        public global::Vercel.AutoSDKSharedb7e537bead367337BindingType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb7e537bead367337Binding" /> class.
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
        public AutoSDKSharedb7e537bead367337Binding(
            string env,
            string service,
            global::Vercel.AutoSDKSharedb7e537bead367337BindingFormat format,
            global::Vercel.AutoSDKSharedb7e537bead367337BindingType? type)
        {
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
            this.Format = format;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb7e537bead367337Binding" /> class.
        /// </summary>
        public AutoSDKSharedb7e537bead367337Binding()
        {
        }

    }
}