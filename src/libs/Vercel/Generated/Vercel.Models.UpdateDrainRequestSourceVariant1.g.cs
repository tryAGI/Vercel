
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDrainRequestSourceVariant1
    {
        /// <summary>
        /// Default Value: integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalResourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainRequestSourceVariant1" /> class.
        /// </summary>
        /// <param name="externalResourceId"></param>
        /// <param name="kind">
        /// Default Value: integration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDrainRequestSourceVariant1(
            string externalResourceId,
            string? kind)
        {
            this.Kind = kind;
            this.ExternalResourceId = externalResourceId ?? throw new global::System.ArgumentNullException(nameof(externalResourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainRequestSourceVariant1" /> class.
        /// </summary>
        public UpdateDrainRequestSourceVariant1()
        {
        }
    }
}