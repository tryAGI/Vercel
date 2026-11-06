
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectCheckRequestSourceVariant3
    {
        /// <summary>
        /// Imports Git provider check results, such as GitHub check runs or commit statuses, as Deployment Checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// The Git provider check name or context to match, for example a GitHub Actions job name.
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
        /// <param name="kind">
        /// Imports Git provider check results, such as GitHub check runs or commit statuses, as Deployment Checks.
        /// </param>
        /// <param name="externalCheckName">
        /// The Git provider check name or context to match, for example a GitHub Actions job name.
        /// </param>
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