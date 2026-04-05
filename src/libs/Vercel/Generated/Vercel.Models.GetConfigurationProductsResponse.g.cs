
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("products")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetConfigurationProductsResponseProduct> Products { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationProductsResponseIntegration Integration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationProductsResponseConfiguration Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponse" /> class.
        /// </summary>
        /// <param name="products"></param>
        /// <param name="integration"></param>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponse(
            global::System.Collections.Generic.IList<global::Vercel.GetConfigurationProductsResponseProduct> products,
            global::Vercel.GetConfigurationProductsResponseIntegration integration,
            global::Vercel.GetConfigurationProductsResponseConfiguration configuration)
        {
            this.Products = products ?? throw new global::System.ArgumentNullException(nameof(products));
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponse" /> class.
        /// </summary>
        public GetConfigurationProductsResponse()
        {
        }
    }
}