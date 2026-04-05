
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteSharedEnvVariableResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.DeleteSharedEnvVariableResponseFailedItem> Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSharedEnvVariableResponse" /> class.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="failed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteSharedEnvVariableResponse(
            global::System.Collections.Generic.IList<string> deleted,
            global::System.Collections.Generic.IList<global::Vercel.DeleteSharedEnvVariableResponseFailedItem> failed)
        {
            this.Deleted = deleted ?? throw new global::System.ArgumentNullException(nameof(deleted));
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSharedEnvVariableResponse" /> class.
        /// </summary>
        public DeleteSharedEnvVariableResponse()
        {
        }
    }
}