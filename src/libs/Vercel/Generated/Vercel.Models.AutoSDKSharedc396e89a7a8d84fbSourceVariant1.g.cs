
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc396e89a7a8d84fbSourceVariant1
    {
        /// <summary>
        /// Informational marker for a system-owned default drain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultFor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc396e89a7a8d84fbSourceVariant1DefaultForJsonConverter))]
        public global::Vercel.AutoSDKSharedc396e89a7a8d84fbSourceVariant1DefaultFor? DefaultFor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc396e89a7a8d84fbSourceVariant1KindJsonConverter))]
        public global::Vercel.AutoSDKSharedc396e89a7a8d84fbSourceVariant1Kind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc396e89a7a8d84fbSourceVariant1" /> class.
        /// </summary>
        /// <param name="defaultFor">
        /// Informational marker for a system-owned default drain.
        /// </param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc396e89a7a8d84fbSourceVariant1(
            global::Vercel.AutoSDKSharedc396e89a7a8d84fbSourceVariant1DefaultFor? defaultFor,
            global::Vercel.AutoSDKSharedc396e89a7a8d84fbSourceVariant1Kind kind)
        {
            this.DefaultFor = defaultFor;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc396e89a7a8d84fbSourceVariant1" /> class.
        /// </summary>
        public AutoSDKSharedc396e89a7a8d84fbSourceVariant1()
        {
        }

    }
}