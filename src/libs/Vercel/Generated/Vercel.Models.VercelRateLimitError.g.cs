
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VercelRateLimitError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AllOfJsonConverter<global::Vercel.VercelBaseError, global::Vercel.VercelRateLimitErrorError>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AllOf<global::Vercel.VercelBaseError, global::Vercel.VercelRateLimitErrorError> Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VercelRateLimitError" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VercelRateLimitError(
            global::Vercel.AllOf<global::Vercel.VercelBaseError, global::Vercel.VercelRateLimitErrorError> error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VercelRateLimitError" /> class.
        /// </summary>
        public VercelRateLimitError()
        {
        }
    }
}