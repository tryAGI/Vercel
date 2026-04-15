
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant157Project
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldConnectConfigurations")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant157ProjectOldConnectConfiguration>? OldConnectConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newConnectConfigurations")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant157ProjectNewConnectConfiguration>? NewConnectConfigurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant157Project" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="oldConnectConfigurations"></param>
        /// <param name="newConnectConfigurations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant157Project(
            string id,
            string? name,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant157ProjectOldConnectConfiguration>? oldConnectConfigurations,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant157ProjectNewConnectConfiguration>? newConnectConfigurations)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.OldConnectConfigurations = oldConnectConfigurations;
            this.NewConnectConfigurations = newConnectConfigurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant157Project" /> class.
        /// </summary>
        public UserEventPayloadVariant157Project()
        {
        }
    }
}