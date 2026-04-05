
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFlagVersionsResponseVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Revision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListFlagVersionsResponseVersionData Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FlagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changedEnvironments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ChangedEnvironments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Vercel.ListFlagVersionsResponseVersionMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersion" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="revision"></param>
        /// <param name="createdAt"></param>
        /// <param name="data"></param>
        /// <param name="flagId"></param>
        /// <param name="changedEnvironments"></param>
        /// <param name="createdBy"></param>
        /// <param name="message"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListFlagVersionsResponseVersion(
            string id,
            double revision,
            double createdAt,
            global::Vercel.ListFlagVersionsResponseVersionData data,
            string flagId,
            global::System.Collections.Generic.IList<string> changedEnvironments,
            string? createdBy,
            string? message,
            global::Vercel.ListFlagVersionsResponseVersionMetadata? metadata)
        {
            this.CreatedBy = createdBy;
            this.Message = message;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Revision = revision;
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FlagId = flagId ?? throw new global::System.ArgumentNullException(nameof(flagId));
            this.ChangedEnvironments = changedEnvironments ?? throw new global::System.ArgumentNullException(nameof(changedEnvironments));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersion" /> class.
        /// </summary>
        public ListFlagVersionsResponseVersion()
        {
        }
    }
}