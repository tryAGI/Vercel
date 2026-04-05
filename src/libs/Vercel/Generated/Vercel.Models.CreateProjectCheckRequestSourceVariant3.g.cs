
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectCheckRequestSourceVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalCheckName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalCheckName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectCheckRequestSourceVariant3ProviderJsonConverter))]
        public global::Vercel.CreateProjectCheckRequestSourceVariant3Provider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectCheckRequestSourceVariant3" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="externalCheckName"></param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectCheckRequestSourceVariant3(
            string kind,
            string externalCheckName,
            global::Vercel.CreateProjectCheckRequestSourceVariant3Provider provider)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.ExternalCheckName = externalCheckName ?? throw new global::System.ArgumentNullException(nameof(externalCheckName));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectCheckRequestSourceVariant3" /> class.
        /// </summary>
        public CreateProjectCheckRequestSourceVariant3()
        {
        }
    }
}