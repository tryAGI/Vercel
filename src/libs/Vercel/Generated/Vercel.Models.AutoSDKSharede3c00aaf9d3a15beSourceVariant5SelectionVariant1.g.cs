
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1KindJsonConverter))]
        public global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1Kind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1(
            global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1Kind kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1" /> class.
        /// </summary>
        public AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1()
        {
        }

    }
}