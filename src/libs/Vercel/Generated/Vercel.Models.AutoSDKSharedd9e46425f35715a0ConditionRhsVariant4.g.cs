
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd9e46425f35715a0ConditionRhsVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Flags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd9e46425f35715a0ConditionRhsVariant4TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedd9e46425f35715a0ConditionRhsVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0ConditionRhsVariant4" /> class.
        /// </summary>
        /// <param name="flags"></param>
        /// <param name="pattern"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd9e46425f35715a0ConditionRhsVariant4(
            string flags,
            string pattern,
            global::Vercel.AutoSDKSharedd9e46425f35715a0ConditionRhsVariant4Type type)
        {
            this.Flags = flags ?? throw new global::System.ArgumentNullException(nameof(flags));
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0ConditionRhsVariant4" /> class.
        /// </summary>
        public AutoSDKSharedd9e46425f35715a0ConditionRhsVariant4()
        {
        }

    }
}