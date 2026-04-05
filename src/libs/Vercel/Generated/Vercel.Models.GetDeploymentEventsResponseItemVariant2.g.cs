
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentEventsResponseItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Created { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentEventsResponseItemVariant2Info Info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Serial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentEventsResponseItemVariant2TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentEventsResponseItemVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentEventsResponseItemVariant2LevelJsonConverter))]
        public global::Vercel.GetDeploymentEventsResponseItemVariant2Level? Level { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseItemVariant2" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="date"></param>
        /// <param name="deploymentId"></param>
        /// <param name="id"></param>
        /// <param name="info"></param>
        /// <param name="serial"></param>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="level"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentEventsResponseItemVariant2(
            double created,
            double date,
            string deploymentId,
            string id,
            global::Vercel.GetDeploymentEventsResponseItemVariant2Info info,
            string serial,
            global::Vercel.GetDeploymentEventsResponseItemVariant2Type type,
            string? text,
            global::Vercel.GetDeploymentEventsResponseItemVariant2Level? level)
        {
            this.Created = created;
            this.Date = date;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Info = info ?? throw new global::System.ArgumentNullException(nameof(info));
            this.Serial = serial ?? throw new global::System.ArgumentNullException(nameof(serial));
            this.Text = text;
            this.Type = type;
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseItemVariant2" /> class.
        /// </summary>
        public GetDeploymentEventsResponseItemVariant2()
        {
        }
    }
}