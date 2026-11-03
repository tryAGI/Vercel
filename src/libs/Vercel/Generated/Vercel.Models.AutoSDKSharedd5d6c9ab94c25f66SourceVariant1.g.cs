
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd5d6c9ab94c25f66SourceVariant1
    {
        /// <summary>
        /// Informational marker for a system-owned default drain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultFor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultForJsonConverter))]
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultFor? DefaultFor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd5d6c9ab94c25f66SourceVariant1KindJsonConverter))]
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SourceVariant1Kind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5d6c9ab94c25f66SourceVariant1" /> class.
        /// </summary>
        /// <param name="defaultFor">
        /// Informational marker for a system-owned default drain.
        /// </param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd5d6c9ab94c25f66SourceVariant1(
            global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultFor? defaultFor,
            global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SourceVariant1Kind kind)
        {
            this.DefaultFor = defaultFor;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5d6c9ab94c25f66SourceVariant1" /> class.
        /// </summary>
        public AutoSDKSharedd5d6c9ab94c25f66SourceVariant1()
        {
        }

    }
}