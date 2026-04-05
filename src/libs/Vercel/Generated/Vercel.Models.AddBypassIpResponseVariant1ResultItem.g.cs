
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddBypassIpResponseVariant1ResultItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("OwnerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("IsProjectRule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsProjectRule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBypassIpResponseVariant1ResultItem" /> class.
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="id"></param>
        /// <param name="domain"></param>
        /// <param name="projectId"></param>
        /// <param name="note"></param>
        /// <param name="isProjectRule"></param>
        /// <param name="ip"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddBypassIpResponseVariant1ResultItem(
            string ownerId,
            string id,
            string domain,
            string projectId,
            string note,
            bool isProjectRule,
            string? ip)
        {
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Ip = ip;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
            this.IsProjectRule = isProjectRule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBypassIpResponseVariant1ResultItem" /> class.
        /// </summary>
        public AddBypassIpResponseVariant1ResultItem()
        {
        }
    }
}