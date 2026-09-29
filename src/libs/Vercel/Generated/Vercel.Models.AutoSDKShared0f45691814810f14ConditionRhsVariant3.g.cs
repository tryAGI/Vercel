
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0f45691814810f14ConditionRhsVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant3ItemVariant1, global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant3ItemVariant2>> Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0f45691814810f14ConditionRhsVariant3TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f45691814810f14ConditionRhsVariant3" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0f45691814810f14ConditionRhsVariant3(
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant3ItemVariant1, global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant3ItemVariant2>> items,
            global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant3Type type)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f45691814810f14ConditionRhsVariant3" /> class.
        /// </summary>
        public AutoSDKShared0f45691814810f14ConditionRhsVariant3()
        {
        }

    }
}