
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSharedEnvVariableRequestEv
    {
        /// <summary>
        /// The name of the Shared Environment Variable<br/>
        /// Example: API_URL
        /// </summary>
        /// <example>API_URL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The value of the Shared Environment Variable<br/>
        /// Example: https://api.vercel.com
        /// </summary>
        /// <example>https://api.vercel.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateSharedEnvVariableRequestEv" /> class.
        /// </summary>
        /// <param name="key">
        /// The name of the Shared Environment Variable<br/>
        /// Example: API_URL
        /// </param>
        /// <param name="value">
        /// The value of the Shared Environment Variable<br/>
        /// Example: https://api.vercel.com
        /// </param>
        /// <param name="comment">
        /// A comment to add context on what this Shared Environment Variable is for<br/>
        /// Example: database connection string for production
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSharedEnvVariableRequestEv(
            string key,
            string value,
            string? comment)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSharedEnvVariableRequestEv" /> class.
        /// </summary>
        public CreateSharedEnvVariableRequestEv()
        {
        }
    }
}