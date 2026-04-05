
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEdgeConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public object? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEdgeConfigRequest" /> class.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEdgeConfigRequest(
            string slug,
            object? items)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEdgeConfigRequest" /> class.
        /// </summary>
        public CreateEdgeConfigRequest()
        {
        }
    }
}