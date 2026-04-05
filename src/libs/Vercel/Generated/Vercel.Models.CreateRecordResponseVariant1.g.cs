
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecordResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordResponseVariant1" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="updated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecordResponseVariant1(
            string uid,
            double updated)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordResponseVariant1" /> class.
        /// </summary>
        public CreateRecordResponseVariant1()
        {
        }
    }
}