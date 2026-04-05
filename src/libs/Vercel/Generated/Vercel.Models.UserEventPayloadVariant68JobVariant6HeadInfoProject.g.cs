
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant68JobVariant6HeadInfoProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultBranch")]
        public string? DefaultBranch { get; set; }

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
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant6HeadInfoProject" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="defaultBranch"></param>
        /// <param name="name"></param>
        /// <param name="namespace"></param>
        /// <param name="path"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant68JobVariant6HeadInfoProject(
            string id,
            string? defaultBranch,
            string? name,
            string? @namespace,
            string? path,
            string? url)
        {
            this.DefaultBranch = defaultBranch;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Namespace = @namespace;
            this.Path = path;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant6HeadInfoProject" /> class.
        /// </summary>
        public UserEventPayloadVariant68JobVariant6HeadInfoProject()
        {
        }
    }
}