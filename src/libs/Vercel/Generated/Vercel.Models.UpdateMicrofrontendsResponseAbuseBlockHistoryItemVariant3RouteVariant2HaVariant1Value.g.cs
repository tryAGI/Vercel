
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Value
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Eq { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Value" /> class.
        /// </summary>
        /// <param name="eq"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Value(
            string eq)
        {
            this.Eq = eq ?? throw new global::System.ArgumentNullException(nameof(eq));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Value" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Value()
        {
        }
    }
}