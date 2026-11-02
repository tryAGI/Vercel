
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFlagsProjectConnectionRequest
    {
        /// <summary>
        /// The project in the same team that may read the flags of this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumerProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsumerProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagsProjectConnectionRequest" /> class.
        /// </summary>
        /// <param name="consumerProjectId">
        /// The project in the same team that may read the flags of this project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagsProjectConnectionRequest(
            string consumerProjectId)
        {
            this.ConsumerProjectId = consumerProjectId ?? throw new global::System.ArgumentNullException(nameof(consumerProjectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagsProjectConnectionRequest" /> class.
        /// </summary>
        public CreateFlagsProjectConnectionRequest()
        {
        }

    }
}