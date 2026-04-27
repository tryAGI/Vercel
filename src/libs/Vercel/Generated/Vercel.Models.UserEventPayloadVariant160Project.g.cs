
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant160Project
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
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant160ProjectOldConnectConfiguration>? OldConnectConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newConnectConfigurations")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant160ProjectNewConnectConfiguration>? NewConnectConfigurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant160Project" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="oldConnectConfigurations"></param>
        /// <param name="newConnectConfigurations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant160Project(
            string id,
            string? name,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant160ProjectOldConnectConfiguration>? oldConnectConfigurations,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant160ProjectNewConnectConfiguration>? newConnectConfigurations)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.OldConnectConfigurations = oldConnectConfigurations;
            this.NewConnectConfigurations = newConnectConfigurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant160Project" /> class.
        /// </summary>
        public UserEventPayloadVariant160Project()
        {
        }
    }
}