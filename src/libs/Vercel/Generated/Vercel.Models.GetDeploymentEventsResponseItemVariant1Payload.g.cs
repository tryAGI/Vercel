
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDeploymentEventsResponseItemVariant1Payload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public double? Created { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Date { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        public global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadInfo? Info { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        public global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadProxy? Proxy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Serial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseItemVariant1Payload" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="deploymentId"></param>
        /// <param name="id"></param>
        /// <param name="serial"></param>
        /// <param name="created"></param>
        /// <param name="info"></param>
        /// <param name="proxy"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentEventsResponseItemVariant1Payload(
            double date,
            string deploymentId,
            string id,
            string serial,
            double? created,
            global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadInfo? info,
            global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadProxy? proxy,
            string? requestId,
            double? statusCode,
            string? text)
        {
            this.Created = created;
            this.Date = date;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Info = info;
            this.Proxy = proxy;
            this.RequestId = requestId;
            this.Serial = serial ?? throw new global::System.ArgumentNullException(nameof(serial));
            this.StatusCode = statusCode;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseItemVariant1Payload" /> class.
        /// </summary>
        public GetDeploymentEventsResponseItemVariant1Payload()
        {
        }

    }
}