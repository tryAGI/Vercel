
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurableLogDrainResponseProjectsMetadataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurableLogDrainResponseProjectsMetadataItemFrameworkJsonConverter))]
        public global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItemFramework? Framework { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestDeployment")]
        public string? LatestDeployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurableLogDrainResponseProjectsMetadataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="framework"></param>
        /// <param name="latestDeployment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurableLogDrainResponseProjectsMetadataItem(
            string id,
            string name,
            global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItemFramework? framework,
            string? latestDeployment)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Framework = framework;
            this.LatestDeployment = latestDeployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurableLogDrainResponseProjectsMetadataItem" /> class.
        /// </summary>
        public GetConfigurableLogDrainResponseProjectsMetadataItem()
        {
        }
    }
}