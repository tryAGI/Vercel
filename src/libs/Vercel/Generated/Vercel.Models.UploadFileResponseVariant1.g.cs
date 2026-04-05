
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadFileResponseVariant1
    {
        /// <summary>
        /// Array of URLs where the file was updated<br/>
        /// Example: [example-upload.aws.com]
        /// </summary>
        /// <example>[example-upload.aws.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileResponseVariant1" /> class.
        /// </summary>
        /// <param name="urls">
        /// Array of URLs where the file was updated<br/>
        /// Example: [example-upload.aws.com]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadFileResponseVariant1(
            global::System.Collections.Generic.IList<string> urls)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileResponseVariant1" /> class.
        /// </summary>
        public UploadFileResponseVariant1()
        {
        }
    }
}