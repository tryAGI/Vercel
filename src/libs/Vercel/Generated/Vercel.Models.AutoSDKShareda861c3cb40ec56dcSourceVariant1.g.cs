
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda861c3cb40ec56dcSourceVariant1
    {
        /// <summary>
        /// Informational marker for a system-owned default drain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultFor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultForJsonConverter))]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultFor? DefaultFor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcSourceVariant1KindJsonConverter))]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcSourceVariant1Kind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcSourceVariant1" /> class.
        /// </summary>
        /// <param name="defaultFor">
        /// Informational marker for a system-owned default drain.
        /// </param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda861c3cb40ec56dcSourceVariant1(
            global::Vercel.AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultFor? defaultFor,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcSourceVariant1Kind kind)
        {
            this.DefaultFor = defaultFor;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcSourceVariant1" /> class.
        /// </summary>
        public AutoSDKShareda861c3cb40ec56dcSourceVariant1()
        {
        }

    }
}