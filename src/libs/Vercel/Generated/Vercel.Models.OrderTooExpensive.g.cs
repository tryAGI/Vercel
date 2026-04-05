
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The total price of the order is too high.
    /// </summary>
    public sealed partial class OrderTooExpensive
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OrderTooExpensiveCodeJsonConverter))]
        public global::Vercel.OrderTooExpensiveCode Code { get; set; }

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
        /// Initializes a new instance of the <see cref="OrderTooExpensive" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderTooExpensive(
            double status,
            string message,
            global::Vercel.OrderTooExpensiveCode code)
        {
            this.Status = status;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTooExpensive" /> class.
        /// </summary>
        public OrderTooExpensive()
        {
        }
    }
}