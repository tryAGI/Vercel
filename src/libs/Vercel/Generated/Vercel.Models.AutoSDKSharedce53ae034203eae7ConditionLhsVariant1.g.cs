
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedce53ae034203eae7ConditionLhsVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedce53ae034203eae7ConditionLhsVariant1TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedce53ae034203eae7ConditionLhsVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedce53ae034203eae7ConditionLhsVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedce53ae034203eae7ConditionLhsVariant1(
            global::Vercel.AutoSDKSharedce53ae034203eae7ConditionLhsVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedce53ae034203eae7ConditionLhsVariant1" /> class.
        /// </summary>
        public AutoSDKSharedce53ae034203eae7ConditionLhsVariant1()
        {
        }

    }
}