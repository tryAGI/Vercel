
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestDrainResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDrainResponseVariant2" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="error"></param>
        /// <param name="endpoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestDrainResponseVariant2(
            string status,
            string error,
            string endpoint)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDrainResponseVariant2" /> class.
        /// </summary>
        public TestDrainResponseVariant2()
        {
        }
    }
}