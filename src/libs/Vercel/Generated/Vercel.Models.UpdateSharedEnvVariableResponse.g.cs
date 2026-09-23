
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateSharedEnvVariableResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateSharedEnvVariableResponseFailedItem> Failed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2e531c6dd7d2b280> Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableResponse" /> class.
        /// </summary>
        /// <param name="failed"></param>
        /// <param name="updated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSharedEnvVariableResponse(
            global::System.Collections.Generic.IList<global::Vercel.UpdateSharedEnvVariableResponseFailedItem> failed,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2e531c6dd7d2b280> updated)
        {
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
            this.Updated = updated ?? throw new global::System.ArgumentNullException(nameof(updated));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableResponse" /> class.
        /// </summary>
        public UpdateSharedEnvVariableResponse()
        {
        }

    }
}