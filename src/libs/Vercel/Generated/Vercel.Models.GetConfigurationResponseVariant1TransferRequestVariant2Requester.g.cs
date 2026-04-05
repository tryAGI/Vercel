
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationResponseVariant1TransferRequestVariant2Requester
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
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationResponseVariant1TransferRequestVariant2Requester" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationResponseVariant1TransferRequestVariant2Requester(
            string name,
            string? email)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationResponseVariant1TransferRequestVariant2Requester" /> class.
        /// </summary>
        public GetConfigurationResponseVariant1TransferRequestVariant2Requester()
        {
        }
    }
}