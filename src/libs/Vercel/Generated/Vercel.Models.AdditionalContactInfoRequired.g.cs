
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Additional contact information is required for the TLD.
    /// </summary>
    public sealed partial class AdditionalContactInfoRequired
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AdditionalContactInfoRequiredCodeJsonConverter))]
        public global::Vercel.AdditionalContactInfoRequiredCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalContactInfoRequired" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdditionalContactInfoRequired(
            double status,
            string message,
            global::Vercel.AdditionalContactInfoRequiredCode code)
        {
            this.Status = status;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalContactInfoRequired" /> class.
        /// </summary>
        public AdditionalContactInfoRequired()
        {
        }
    }
}