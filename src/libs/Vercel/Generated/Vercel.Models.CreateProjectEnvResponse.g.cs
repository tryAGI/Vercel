
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectEnvResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateProjectEnvResponseCreated, global::System.Collections.Generic.IList<global::Vercel.CreateProjectEnvResponseCreatedItem>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.CreateProjectEnvResponseCreated, global::System.Collections.Generic.IList<global::Vercel.CreateProjectEnvResponseCreatedItem>> Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateProjectEnvResponseFailedItem> Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectEnvResponse" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="failed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectEnvResponse(
            global::Vercel.OneOf<global::Vercel.CreateProjectEnvResponseCreated, global::System.Collections.Generic.IList<global::Vercel.CreateProjectEnvResponseCreatedItem>> created,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectEnvResponseFailedItem> failed)
        {
            this.Created = created;
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectEnvResponse" /> class.
        /// </summary>
        public CreateProjectEnvResponse()
        {
        }
    }
}