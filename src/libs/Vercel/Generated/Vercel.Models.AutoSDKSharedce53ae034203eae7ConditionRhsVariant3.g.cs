
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedce53ae034203eae7ConditionRhsVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant3ItemVariant1, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant3ItemVariant2>> Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedce53ae034203eae7ConditionRhsVariant3TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedce53ae034203eae7ConditionRhsVariant3" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedce53ae034203eae7ConditionRhsVariant3(
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant3ItemVariant1, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant3ItemVariant2>> items,
            global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant3Type type)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedce53ae034203eae7ConditionRhsVariant3" /> class.
        /// </summary>
        public AutoSDKSharedce53ae034203eae7ConditionRhsVariant3()
        {
        }

    }
}