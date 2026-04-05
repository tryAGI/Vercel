
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptProjectTransferRequestResponseVariant1PartnerCallResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestResponseVariant1PartnerCallResult" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="error"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptProjectTransferRequestResponseVariant1PartnerCallResult(
            global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus status,
            object? error,
            string? code)
        {
            this.Status = status;
            this.Error = error;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestResponseVariant1PartnerCallResult" /> class.
        /// </summary>
        public AcceptProjectTransferRequestResponseVariant1PartnerCallResult()
        {
        }
    }
}