
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProductGuideStep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductGuideStepAction>? Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductGuideStep" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="actions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProductGuideStep(
            string title,
            string content,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductGuideStepAction>? actions)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductGuideStep" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductGuideStep()
        {
        }
    }
}