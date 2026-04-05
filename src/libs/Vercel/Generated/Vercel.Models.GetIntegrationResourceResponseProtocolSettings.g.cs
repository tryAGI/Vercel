
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Any settings provided for the resource to support its product's protocols
    /// </summary>
    public sealed partial class GetIntegrationResourceResponseProtocolSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentation")]
        public global::Vercel.GetIntegrationResourceResponseProtocolSettingsExperimentation? Experimentation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseProtocolSettings" /> class.
        /// </summary>
        /// <param name="experimentation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationResourceResponseProtocolSettings(
            global::Vercel.GetIntegrationResourceResponseProtocolSettingsExperimentation? experimentation)
        {
            this.Experimentation = experimentation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseProtocolSettings" /> class.
        /// </summary>
        public GetIntegrationResourceResponseProtocolSettings()
        {
        }
    }
}