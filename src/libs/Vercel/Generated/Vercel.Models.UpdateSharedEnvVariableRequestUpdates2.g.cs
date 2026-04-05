
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSharedEnvVariableRequestUpdates2
    {
        /// <summary>
        /// The name of the Shared Environment Variable<br/>
        /// Example: API_URL
        /// </summary>
        /// <example>API_URL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The value of the Shared Environment Variable<br/>
        /// Example: https://api.vercel.com
        /// </summary>
        /// <example>https://api.vercel.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The target environment of the Shared Environment Variable<br/>
        /// Example: [production, preview]
        /// </summary>
        /// <example>[production, preview]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateSharedEnvVariableRequestUpdatesTargetItem>? Target { get; set; }

        /// <summary>
        /// Associate a Shared Environment Variable to projects.<br/>
        /// Example: [prj_2WjyKQmM8ZnGcJsPWMrHRHrE, prj_2WjyKQmM8ZnGcJsPWMrHRCRV]
        /// </summary>
        /// <example>[prj_2WjyKQmM8ZnGcJsPWMrHRHrE, prj_2WjyKQmM8ZnGcJsPWMrHRCRV]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Collections.Generic.IList<string>? ProjectId { get; set; }

        /// <summary>
        /// Incrementally update project linking without specifying the full list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIdUpdates")]
        public global::Vercel.UpdateSharedEnvVariableRequestUpdatesProjectIdUpdates? ProjectIdUpdates { get; set; }

        /// <summary>
        /// The new type of the Shared Environment Variable<br/>
        /// Example: encrypted
        /// </summary>
        /// <example>encrypted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateSharedEnvVariableRequestUpdatesTypeJsonConverter))]
        public global::Vercel.UpdateSharedEnvVariableRequestUpdatesType? Type { get; set; }

        /// <summary>
        /// A comment to add context on what this Shared Environment Variable is for<br/>
        /// Example: database connection string for production
        /// </summary>
        /// <example>database connection string for production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableRequestUpdates2" /> class.
        /// </summary>
        /// <param name="key">
        /// The name of the Shared Environment Variable<br/>
        /// Example: API_URL
        /// </param>
        /// <param name="value">
        /// The value of the Shared Environment Variable<br/>
        /// Example: https://api.vercel.com
        /// </param>
        /// <param name="target">
        /// The target environment of the Shared Environment Variable<br/>
        /// Example: [production, preview]
        /// </param>
        /// <param name="projectId">
        /// Associate a Shared Environment Variable to projects.<br/>
        /// Example: [prj_2WjyKQmM8ZnGcJsPWMrHRHrE, prj_2WjyKQmM8ZnGcJsPWMrHRCRV]
        /// </param>
        /// <param name="projectIdUpdates">
        /// Incrementally update project linking without specifying the full list
        /// </param>
        /// <param name="type">
        /// The new type of the Shared Environment Variable<br/>
        /// Example: encrypted
        /// </param>
        /// <param name="comment">
        /// A comment to add context on what this Shared Environment Variable is for<br/>
        /// Example: database connection string for production
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSharedEnvVariableRequestUpdates2(
            string? key,
            string? value,
            global::System.Collections.Generic.IList<global::Vercel.UpdateSharedEnvVariableRequestUpdatesTargetItem>? target,
            global::System.Collections.Generic.IList<string>? projectId,
            global::Vercel.UpdateSharedEnvVariableRequestUpdatesProjectIdUpdates? projectIdUpdates,
            global::Vercel.UpdateSharedEnvVariableRequestUpdatesType? type,
            string? comment)
        {
            this.Key = key;
            this.Value = value;
            this.Target = target;
            this.ProjectId = projectId;
            this.ProjectIdUpdates = projectIdUpdates;
            this.Type = type;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableRequestUpdates2" /> class.
        /// </summary>
        public UpdateSharedEnvVariableRequestUpdates2()
        {
        }
    }
}