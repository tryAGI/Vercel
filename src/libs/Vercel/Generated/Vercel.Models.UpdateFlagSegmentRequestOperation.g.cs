
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSegmentRequestOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagSegmentRequestOperationActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagSegmentRequestOperationAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagSegmentRequestOperationFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagSegmentRequestOperationField Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Attribute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagSegmentRequestOperationValue Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentRequestOperation" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="field"></param>
        /// <param name="entity"></param>
        /// <param name="attribute"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSegmentRequestOperation(
            global::Vercel.UpdateFlagSegmentRequestOperationAction action,
            global::Vercel.UpdateFlagSegmentRequestOperationField field,
            string entity,
            string attribute,
            global::Vercel.UpdateFlagSegmentRequestOperationValue value)
        {
            this.Action = action;
            this.Field = field;
            this.Entity = entity ?? throw new global::System.ArgumentNullException(nameof(entity));
            this.Attribute = attribute ?? throw new global::System.ArgumentNullException(nameof(attribute));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentRequestOperation" /> class.
        /// </summary>
        public UpdateFlagSegmentRequestOperation()
        {
        }
    }
}