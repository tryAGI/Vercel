
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDrainResponseVariant1DeliveryVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant1DeliveryVariant4TypeJsonConverter))]
        public global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4Type Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant1DeliveryVariant4EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4Encoding Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant1DeliveryVariant4CompressionJsonConverter))]
        public global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4Compression Compression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileStructure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant1DeliveryVariant4FileStructureJsonConverter))]
        public global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4FileStructure FileStructure { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant1DeliveryVariant4ServerSideEncryptionJsonConverter))]
        public global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4ServerSideEncryption? ServerSideEncryption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectAcl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant1DeliveryVariant4ObjectAclJsonConverter))]
        public global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl? ObjectAcl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainResponseVariant1DeliveryVariant4" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="encoding"></param>
        /// <param name="roleArn"></param>
        /// <param name="region"></param>
        /// <param name="type"></param>
        /// <param name="compression"></param>
        /// <param name="fileStructure"></param>
        /// <param name="serverSideEncryption"></param>
        /// <param name="objectAcl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDrainResponseVariant1DeliveryVariant4(
            string endpoint,
            global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4Encoding encoding,
            string roleArn,
            string region,
            global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4Type type,
            global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4Compression compression,
            global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4FileStructure fileStructure,
            global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4ServerSideEncryption? serverSideEncryption,
            global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl? objectAcl)
        {
            this.Type = type;
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
        /// Initializes a new instance of the <see cref="UpdateDrainResponseVariant1DeliveryVariant4" /> class.
        /// </summary>
        public UpdateDrainResponseVariant1DeliveryVariant4()
        {
        }

    }
}