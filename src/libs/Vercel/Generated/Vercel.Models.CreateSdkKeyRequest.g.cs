
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSdkKeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdkKeyType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateSdkKeyRequestSdkKeyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateSdkKeyRequestSdkKeyType SdkKeyType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSdkKeyRequest" /> class.
        /// </summary>
        /// <param name="sdkKeyType"></param>
        /// <param name="environment"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSdkKeyRequest(
            global::Vercel.CreateSdkKeyRequestSdkKeyType sdkKeyType,
            string environment,
            string? label)
        {
            this.SdkKeyType = sdkKeyType;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSdkKeyRequest" /> class.
        /// </summary>
        public CreateSdkKeyRequest()
        {
        }
    }
}