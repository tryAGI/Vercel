
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedb4706d78b2b82e72ResourcesRequests
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb4706d78b2b82e72ResourcesRequests" /> class.
        /// </summary>
        /// <param name="memory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb4706d78b2b82e72ResourcesRequests(
            global::Vercel.AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory memory)
        {
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb4706d78b2b82e72ResourcesRequests" /> class.
        /// </summary>
        public AutoSDKSharedb4706d78b2b82e72ResourcesRequests()
        {
        }

    }
}