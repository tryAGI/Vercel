
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateConditionalBypassRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditionGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateConditionalBypassRequestConditionGroupItem> ConditionGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConditionalBypassRequest" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="conditionGroup"></param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConditionalBypassRequest(
            string domain,
            global::System.Collections.Generic.IList<global::Vercel.CreateConditionalBypassRequestConditionGroupItem> conditionGroup,
            string? note)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.ConditionGroup = conditionGroup ?? throw new global::System.ArgumentNullException(nameof(conditionGroup));
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConditionalBypassRequest" /> class.
        /// </summary>
        public CreateConditionalBypassRequest()
        {
        }

    }
}