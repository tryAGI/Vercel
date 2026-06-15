
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainRequestDeliveryVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainRequestDeliveryVariant3EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDrainRequestDeliveryVariant3Encoding Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainRequestDeliveryVariant3CompressionJsonConverter))]
        public global::Vercel.CreateDrainRequestDeliveryVariant3Compression Compression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileStructure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainRequestDeliveryVariant3FileStructureJsonConverter))]
        public global::Vercel.CreateDrainRequestDeliveryVariant3FileStructure FileStructure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roleArn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverSideEncryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainRequestDeliveryVariant3ServerSideEncryptionJsonConverter))]
        public global::Vercel.CreateDrainRequestDeliveryVariant3ServerSideEncryption? ServerSideEncryption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectAcl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainRequestDeliveryVariant3ObjectAclJsonConverter))]
        public global::Vercel.CreateDrainRequestDeliveryVariant3ObjectAcl? ObjectAcl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequestDeliveryVariant3" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="endpoint"></param>
        /// <param name="encoding"></param>
        /// <param name="roleArn"></param>
        /// <param name="region"></param>
        /// <param name="compression"></param>
        /// <param name="fileStructure"></param>
        /// <param name="serverSideEncryption"></param>
        /// <param name="objectAcl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainRequestDeliveryVariant3(
            string type,
            string endpoint,
            global::Vercel.CreateDrainRequestDeliveryVariant3Encoding encoding,
            string roleArn,
            string region,
            global::Vercel.CreateDrainRequestDeliveryVariant3Compression compression,
            global::Vercel.CreateDrainRequestDeliveryVariant3FileStructure fileStructure,
            global::Vercel.CreateDrainRequestDeliveryVariant3ServerSideEncryption? serverSideEncryption,
            global::Vercel.CreateDrainRequestDeliveryVariant3ObjectAcl? objectAcl)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Encoding = encoding;
            this.Compression = compression;
            this.FileStructure = fileStructure;
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.ServerSideEncryption = serverSideEncryption;
            this.ObjectAcl = objectAcl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequestDeliveryVariant3" /> class.
        /// </summary>
        public CreateDrainRequestDeliveryVariant3()
        {
        }

    }
}