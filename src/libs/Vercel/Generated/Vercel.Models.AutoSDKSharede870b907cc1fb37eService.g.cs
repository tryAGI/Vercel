
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede870b907cc1fb37eService
    {
        /// <summary>
        /// Framework slug, when the service has one (omitted otherwise).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede870b907cc1fb37eServiceFrameworkJsonConverter))]
        public global::Vercel.AutoSDKSharede870b907cc1fb37eServiceFramework? Framework { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede870b907cc1fb37eServiceServiceTypeJsonConverter))]
        public global::Vercel.AutoSDKSharede870b907cc1fb37eServiceServiceType? ServiceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede870b907cc1fb37eService" /> class.
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
        public AutoSDKSharede870b907cc1fb37eService(
            string serviceName,
            global::Vercel.AutoSDKSharede870b907cc1fb37eServiceFramework? framework,
            string? runtime,
            global::Vercel.AutoSDKSharede870b907cc1fb37eServiceServiceType? serviceType)
        {
            this.Framework = framework;
            this.Runtime = runtime;
            this.ServiceName = serviceName ?? throw new global::System.ArgumentNullException(nameof(serviceName));
            this.ServiceType = serviceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede870b907cc1fb37eService" /> class.
        /// </summary>
        public AutoSDKSharede870b907cc1fb37eService()
        {
        }

    }
}