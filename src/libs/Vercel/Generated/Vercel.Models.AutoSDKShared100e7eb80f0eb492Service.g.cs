
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared100e7eb80f0eb492Service
    {
        /// <summary>
        /// Framework slug, when the service has one (omitted otherwise).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared100e7eb80f0eb492ServiceFrameworkJsonConverter))]
        public global::Vercel.AutoSDKShared100e7eb80f0eb492ServiceFramework? Framework { get; set; }

        /// <summary>
        /// Generic runtime, e.g. 'node' | 'python' | 'go' | 'ruby' | 'rust' (Service.runtime). Omitted for static builds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

        /// <summary>
        /// Service name from the deployment (Service.name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceName { get; set; }

        /// <summary>
        /// Service kind (Service.type). Omitted for schemas that do not define one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared100e7eb80f0eb492ServiceServiceTypeJsonConverter))]
        public global::Vercel.AutoSDKShared100e7eb80f0eb492ServiceServiceType? ServiceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared100e7eb80f0eb492Service" /> class.
        /// </summary>
        /// <param name="serviceName">
        /// Service name from the deployment (Service.name).
        /// </param>
        /// <param name="framework">
        /// Framework slug, when the service has one (omitted otherwise).
        /// </param>
        /// <param name="runtime">
        /// Generic runtime, e.g. 'node' | 'python' | 'go' | 'ruby' | 'rust' (Service.runtime). Omitted for static builds.
        /// </param>
        /// <param name="serviceType">
        /// Service kind (Service.type). Omitted for schemas that do not define one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared100e7eb80f0eb492Service(
            string serviceName,
            global::Vercel.AutoSDKShared100e7eb80f0eb492ServiceFramework? framework,
            string? runtime,
            global::Vercel.AutoSDKShared100e7eb80f0eb492ServiceServiceType? serviceType)
        {
            this.Framework = framework;
            this.Runtime = runtime;
            this.ServiceName = serviceName ?? throw new global::System.ArgumentNullException(nameof(serviceName));
            this.ServiceType = serviceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared100e7eb80f0eb492Service" /> class.
        /// </summary>
        public AutoSDKShared100e7eb80f0eb492Service()
        {
        }

    }
}