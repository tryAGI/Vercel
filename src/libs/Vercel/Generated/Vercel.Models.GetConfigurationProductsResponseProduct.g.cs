
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProduct
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
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocols")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationProductsResponseProductProtocols Protocols { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryProtocol")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductPrimaryProtocolJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductPrimaryProtocol? PrimaryProtocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadataSchema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationProductsResponseProductMetadataSchema MetadataSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProduct" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="protocols"></param>
        /// <param name="metadataSchema"></param>
        /// <param name="primaryProtocol"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProduct(
            string id,
            string slug,
            string name,
            global::Vercel.GetConfigurationProductsResponseProductProtocols protocols,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchema metadataSchema,
            global::Vercel.GetConfigurationProductsResponseProductPrimaryProtocol? primaryProtocol)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Protocols = protocols ?? throw new global::System.ArgumentNullException(nameof(protocols));
            this.PrimaryProtocol = primaryProtocol;
            this.MetadataSchema = metadataSchema ?? throw new global::System.ArgumentNullException(nameof(metadataSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProduct" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProduct()
        {
        }
    }
}