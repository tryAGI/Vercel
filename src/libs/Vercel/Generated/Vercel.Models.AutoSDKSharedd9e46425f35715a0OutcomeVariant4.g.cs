
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd9e46425f35715a0OutcomeVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd9e46425f35715a0OutcomeVariant4TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0OutcomeVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd9e46425f35715a0OutcomeVariant4(
            global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant4Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0OutcomeVariant4" /> class.
        /// </summary>
        public AutoSDKSharedd9e46425f35715a0OutcomeVariant4()
        {
        }

    }
}