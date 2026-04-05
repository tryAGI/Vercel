
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The user on the external platform who triggered the deployment.
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1PlatformCreator
    {
        /// <summary>
        /// Display name of the platform user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL of the platform user's avatar image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1PlatformCreator" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the platform user.
        /// </param>
        /// <param name="avatar">
        /// URL of the platform user's avatar image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1PlatformCreator(
            string name,
            string? avatar)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Avatar = avatar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1PlatformCreator" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1PlatformCreator()
        {
        }
    }
}