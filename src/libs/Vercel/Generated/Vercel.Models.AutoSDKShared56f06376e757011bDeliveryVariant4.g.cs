
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared56f06376e757011bDeliveryVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared56f06376e757011bDeliveryVariant4CompressionJsonConverter))]
        public global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4Compression Compression { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared56f06376e757011bDeliveryVariant4EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4Encoding Encoding { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileStructure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared56f06376e757011bDeliveryVariant4FileStructureJsonConverter))]
        public global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4FileStructure FileStructure { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectAcl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAclJsonConverter))]
        public global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl? ObjectAcl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roleArn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverSideEncryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared56f06376e757011bDeliveryVariant4ServerSideEncryptionJsonConverter))]
        public global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4ServerSideEncryption? ServerSideEncryption { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared56f06376e757011bDeliveryVariant4TypeJsonConverter))]
        public global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared56f06376e757011bDeliveryVariant4" /> class.
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="endpoint"></param>
        /// <param name="region"></param>
        /// <param name="roleArn"></param>
        /// <param name="compression"></param>
        /// <param name="fileStructure"></param>
        /// <param name="objectAcl"></param>
        /// <param name="serverSideEncryption"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared56f06376e757011bDeliveryVariant4(
            global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4Encoding encoding,
            string endpoint,
            string region,
            string roleArn,
            global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4Compression compression,
            global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4FileStructure fileStructure,
            global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl? objectAcl,
            global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4ServerSideEncryption? serverSideEncryption,
            global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant4Type type)
        {
            this.Compression = compression;
            this.Encoding = encoding;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.FileStructure = fileStructure;
            this.ObjectAcl = objectAcl;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.ServerSideEncryption = serverSideEncryption;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared56f06376e757011bDeliveryVariant4" /> class.
        /// </summary>
        public AutoSDKShared56f06376e757011bDeliveryVariant4()
        {
        }

    }
}