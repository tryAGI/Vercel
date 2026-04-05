
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecordResponseVariant2
    {
        /// <summary>
        /// The id of the newly created DNS record<br/>
        /// Example: rec_V0fra8eEgQwEpFhYG2vTzC3K
        /// </summary>
        /// <example>rec_V0fra8eEgQwEpFhYG2vTzC3K</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordResponseVariant2" /> class.
        /// </summary>
        /// <param name="uid">
        /// The id of the newly created DNS record<br/>
        /// Example: rec_V0fra8eEgQwEpFhYG2vTzC3K
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecordResponseVariant2(
            string uid)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordResponseVariant2" /> class.
        /// </summary>
        public CreateRecordResponseVariant2()
        {
        }
    }
}