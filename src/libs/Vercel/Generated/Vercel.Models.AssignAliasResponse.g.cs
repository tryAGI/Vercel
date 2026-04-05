
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignAliasResponse
    {
        /// <summary>
        /// The unique identifier of the alias<br/>
        /// Example: 2WjyKQmM8ZnGcJsPWMrHRHrE
        /// </summary>
        /// <example>2WjyKQmM8ZnGcJsPWMrHRHrE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// The assigned alias name<br/>
        /// Example: my-alias.vercel.app
        /// </summary>
        /// <example>my-alias.vercel.app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// The date when the alias was created<br/>
        /// Example: 2017-04-26T23:00:34.232Z
        /// </summary>
        /// <example>2017-04-26T23:00:34.232Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// The unique identifier of the previously aliased deployment, only received when the alias was used before<br/>
        /// Example: dpl_FjvFJncQHQcZMznrUm9EoB8sFuPa
        /// </summary>
        /// <example>dpl_FjvFJncQHQcZMznrUm9EoB8sFuPa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldDeploymentId")]
        public string? OldDeploymentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignAliasResponse" /> class.
        /// </summary>
        /// <param name="uid">
        /// The unique identifier of the alias<br/>
        /// Example: 2WjyKQmM8ZnGcJsPWMrHRHrE
        /// </param>
        /// <param name="alias">
        /// The assigned alias name<br/>
        /// Example: my-alias.vercel.app
        /// </param>
        /// <param name="created">
        /// The date when the alias was created<br/>
        /// Example: 2017-04-26T23:00:34.232Z
        /// </param>
        /// <param name="oldDeploymentId">
        /// The unique identifier of the previously aliased deployment, only received when the alias was used before<br/>
        /// Example: dpl_FjvFJncQHQcZMznrUm9EoB8sFuPa
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignAliasResponse(
            string uid,
            string alias,
            global::System.DateTime created,
            string? oldDeploymentId)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Created = created;
            this.OldDeploymentId = oldDeploymentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignAliasResponse" /> class.
        /// </summary>
        public AssignAliasResponse()
        {
        }
    }
}