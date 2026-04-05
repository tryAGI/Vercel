
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreSecret
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Length { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameworkPublishable")]
        public bool? FrameworkPublishable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreSecret" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="length"></param>
        /// <param name="frameworkPublishable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreSecret(
            string name,
            double length,
            bool? frameworkPublishable)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Length = length;
            this.FrameworkPublishable = frameworkPublishable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreSecret" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreSecret()
        {
        }
    }
}