
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllLogDrainsResponseItemProjectsMetadataItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllLogDrainsResponseItemProjectsMetadataItemFrameworkJsonConverter))]
        public global::Vercel.GetAllLogDrainsResponseItemProjectsMetadataItemFramework? Framework { get; set; }

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
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseItemProjectsMetadataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="framework"></param>
        /// <param name="latestDeployment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllLogDrainsResponseItemProjectsMetadataItem(
            string id,
            string name,
            global::Vercel.GetAllLogDrainsResponseItemProjectsMetadataItemFramework? framework,
            string? latestDeployment)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Framework = framework;
            this.LatestDeployment = latestDeployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseItemProjectsMetadataItem" /> class.
        /// </summary>
        public GetAllLogDrainsResponseItemProjectsMetadataItem()
        {
        }
    }
}