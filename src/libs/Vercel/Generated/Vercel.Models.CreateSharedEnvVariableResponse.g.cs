
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSharedEnvVariableResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateSharedEnvVariableResponseCreatedItem> Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateSharedEnvVariableResponseFailedItem> Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSharedEnvVariableResponse" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="failed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSharedEnvVariableResponse(
            global::System.Collections.Generic.IList<global::Vercel.CreateSharedEnvVariableResponseCreatedItem> created,
            global::System.Collections.Generic.IList<global::Vercel.CreateSharedEnvVariableResponseFailedItem> failed)
        {
            this.Created = created ?? throw new global::System.ArgumentNullException(nameof(created));
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSharedEnvVariableResponse" /> class.
        /// </summary>
        public CreateSharedEnvVariableResponse()
        {
        }
    }
}