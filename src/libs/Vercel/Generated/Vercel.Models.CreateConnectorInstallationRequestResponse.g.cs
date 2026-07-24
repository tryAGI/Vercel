
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorInstallationRequestResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Verifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceCode")]
        public string? DeviceCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateConnectorInstallationRequestResponseConnector Connector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorInstallationRequestResponse" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="request"></param>
        /// <param name="verifier"></param>
        /// <param name="expiresAt"></param>
        /// <param name="connector"></param>
        /// <param name="deviceCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorInstallationRequestResponse(
            string url,
            string request,
            string verifier,
            double expiresAt,
            global::Vercel.CreateConnectorInstallationRequestResponseConnector connector,
            string? deviceCode)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Verifier = verifier ?? throw new global::System.ArgumentNullException(nameof(verifier));
            this.DeviceCode = deviceCode;
            this.ExpiresAt = expiresAt;
            this.Connector = connector ?? throw new global::System.ArgumentNullException(nameof(connector));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorInstallationRequestResponse" /> class.
        /// </summary>
        public CreateConnectorInstallationRequestResponse()
        {
        }

    }
}