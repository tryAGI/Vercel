
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant1KindJsonConverter))]
        public global::Vercel.ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant1Kind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant1" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant1(
            global::Vercel.ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant1Kind kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant1" /> class.
        /// </summary>
        public ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant1()
        {
        }

    }
}