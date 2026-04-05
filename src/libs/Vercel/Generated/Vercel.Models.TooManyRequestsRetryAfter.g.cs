
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TooManyRequestsRetryAfter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("str")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Str { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyRequestsRetryAfter" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="str"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TooManyRequestsRetryAfter(
            double value,
            string str)
        {
            this.Value = value;
            this.Str = str ?? throw new global::System.ArgumentNullException(nameof(str));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyRequestsRetryAfter" /> class.
        /// </summary>
        public TooManyRequestsRetryAfter()
        {
        }
    }
}