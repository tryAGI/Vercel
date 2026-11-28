
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFlagRequestEnvironments
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("production")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedba25b79c660ac1ce Production { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedba25b79c660ac1ce Preview { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("development")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedba25b79c660ac1ce Development { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestEnvironments" /> class.
        /// </summary>
        /// <param name="production"></param>
        /// <param name="preview"></param>
        /// <param name="development"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagRequestEnvironments(
            global::Vercel.AutoSDKSharedba25b79c660ac1ce production,
            global::Vercel.AutoSDKSharedba25b79c660ac1ce preview,
            global::Vercel.AutoSDKSharedba25b79c660ac1ce development)
        {
            this.Production = production ?? throw new global::System.ArgumentNullException(nameof(production));
            this.Preview = preview ?? throw new global::System.ArgumentNullException(nameof(preview));
            this.Development = development ?? throw new global::System.ArgumentNullException(nameof(development));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestEnvironments" /> class.
        /// </summary>
        public CreateFlagRequestEnvironments()
        {
        }

    }
}