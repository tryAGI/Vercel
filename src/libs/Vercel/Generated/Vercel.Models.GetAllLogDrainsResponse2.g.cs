
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllLogDrainsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drains")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseDrainsVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseDrainsVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseDrainsVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseDrainsVariant2Item>> Drains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponse2" /> class.
        /// </summary>
        /// <param name="drains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllLogDrainsResponse2(
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseDrainsVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseDrainsVariant2Item>> drains)
        {
            this.Drains = drains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponse2" /> class.
        /// </summary>
        public GetAllLogDrainsResponse2()
        {
        }
    }
}