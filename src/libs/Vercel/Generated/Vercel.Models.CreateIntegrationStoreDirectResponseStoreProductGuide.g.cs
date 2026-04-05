
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProductGuide
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Framework { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductGuideStep> Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductGuide" /> class.
        /// </summary>
        /// <param name="framework"></param>
        /// <param name="title"></param>
        /// <param name="steps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProductGuide(
            string framework,
            string title,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductGuideStep> steps)
        {
            this.Framework = framework ?? throw new global::System.ArgumentNullException(nameof(framework));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductGuide" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductGuide()
        {
        }
    }
}