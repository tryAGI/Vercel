
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsConfigResponse
    {
        /// <summary>
        /// projectIds are added when the config is uploaded to s3 deployment assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Vercel.GetMicrofrontendsConfigResponseConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigResponse" /> class.
        /// </summary>
        /// <param name="config">
        /// projectIds are added when the config is uploaded to s3 deployment assets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsConfigResponse(
            global::Vercel.GetMicrofrontendsConfigResponseConfig? config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigResponse" /> class.
        /// </summary>
        public GetMicrofrontendsConfigResponse()
        {
        }
    }
}