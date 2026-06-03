
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthUserAccountUpdateContextManagedTeam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserAccountUpdateContextManagedTeam" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="avatar"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserAccountUpdateContextManagedTeam(
            string name,
            string? avatar)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Avatar = avatar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserAccountUpdateContextManagedTeam" /> class.
        /// </summary>
        public AuthUserAccountUpdateContextManagedTeam()
        {
        }

    }
}