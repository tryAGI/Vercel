
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0001bb8e789a120eSourceVariant1
    {
        /// <summary>
        /// Informational marker for a system-owned default drain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultFor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0001bb8e789a120eSourceVariant1DefaultForJsonConverter))]
        public global::Vercel.AutoSDKShared0001bb8e789a120eSourceVariant1DefaultFor? DefaultFor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0001bb8e789a120eSourceVariant1KindJsonConverter))]
        public global::Vercel.AutoSDKShared0001bb8e789a120eSourceVariant1Kind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0001bb8e789a120eSourceVariant1" /> class.
        /// </summary>
        /// <param name="defaultFor">
        /// Informational marker for a system-owned default drain.
        /// </param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0001bb8e789a120eSourceVariant1(
            global::Vercel.AutoSDKShared0001bb8e789a120eSourceVariant1DefaultFor? defaultFor,
            global::Vercel.AutoSDKShared0001bb8e789a120eSourceVariant1Kind kind)
        {
            this.DefaultFor = defaultFor;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0001bb8e789a120eSourceVariant1" /> class.
        /// </summary>
        public AutoSDKShared0001bb8e789a120eSourceVariant1()
        {
        }

    }
}