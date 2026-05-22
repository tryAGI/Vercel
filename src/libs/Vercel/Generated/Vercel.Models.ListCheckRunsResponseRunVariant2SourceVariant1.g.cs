
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Config-driven CI task — check run `source` only (no parent check).
    /// </summary>
    public sealed partial class ListCheckRunsResponseRunVariant2SourceVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListCheckRunsResponseRunVariant2SourceVariant1SubKindJsonConverter))]
        public global::Vercel.ListCheckRunsResponseRunVariant2SourceVariant1SubKind SubKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListCheckRunsResponseRunVariant2SourceVariant1OriginJsonConverter))]
        public global::Vercel.ListCheckRunsResponseRunVariant2SourceVariant1Origin Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCheckRunsResponseRunVariant2SourceVariant1" /> class.
        /// </summary>
        /// <param name="subKind"></param>
        /// <param name="origin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCheckRunsResponseRunVariant2SourceVariant1(
            global::Vercel.ListCheckRunsResponseRunVariant2SourceVariant1SubKind subKind,
            global::Vercel.ListCheckRunsResponseRunVariant2SourceVariant1Origin origin)
        {
            this.SubKind = subKind;
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCheckRunsResponseRunVariant2SourceVariant1" /> class.
        /// </summary>
        public ListCheckRunsResponseRunVariant2SourceVariant1()
        {
        }

    }
}