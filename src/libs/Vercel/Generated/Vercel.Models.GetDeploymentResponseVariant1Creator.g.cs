
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Information about the deployment creator
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1Creator
    {
        /// <summary>
        /// The ID of the user that created the deployment<br/>
        /// Example: 96SnxkFiMyVKsK3pnoHfx3Hz
        /// </summary>
        /// <example>96SnxkFiMyVKsK3pnoHfx3Hz</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// The username of the user that created the deployment<br/>
        /// Example: john-doe
        /// </summary>
        /// <example>john-doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// The avatar of the user that created the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1Creator" /> class.
        /// </summary>
        /// <param name="uid">
        /// The ID of the user that created the deployment<br/>
        /// Example: 96SnxkFiMyVKsK3pnoHfx3Hz
        /// </param>
        /// <param name="username">
        /// The username of the user that created the deployment<br/>
        /// Example: john-doe
        /// </param>
        /// <param name="avatar">
        /// The avatar of the user that created the deployment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1Creator(
            string uid,
            string? username,
            string? avatar)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Username = username;
            this.Avatar = avatar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1Creator" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1Creator()
        {
        }
    }
}