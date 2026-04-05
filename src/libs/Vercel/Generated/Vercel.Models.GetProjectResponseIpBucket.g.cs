
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseIpBucket
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportUntil")]
        public double? SupportUntil { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseIpBucket" /> class.
        /// </summary>
        /// <param name="bucket"></param>
        /// <param name="supportUntil"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseIpBucket(
            string bucket,
            double? supportUntil)
        {
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.SupportUntil = supportUntil;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseIpBucket" /> class.
        /// </summary>
        public GetProjectResponseIpBucket()
        {
        }
    }
}