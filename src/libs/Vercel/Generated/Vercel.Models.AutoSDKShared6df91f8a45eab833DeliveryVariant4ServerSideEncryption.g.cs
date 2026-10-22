
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833DeliveryVariant4ServerSideEncryption
    {
        /// <summary>
        ///
        /// </summary>
        Aes256,
        /// <summary>
        ///
        /// </summary>
        Aws_kms,
        /// <summary>
        ///
        /// </summary>
        Aws_kms_dsse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6df91f8a45eab833DeliveryVariant4ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833DeliveryVariant4ServerSideEncryption value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833DeliveryVariant4ServerSideEncryption.Aes256 => "AES256",
                AutoSDKShared6df91f8a45eab833DeliveryVariant4ServerSideEncryption.Aws_kms => "aws:kms",
                AutoSDKShared6df91f8a45eab833DeliveryVariant4ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833DeliveryVariant4ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => AutoSDKShared6df91f8a45eab833DeliveryVariant4ServerSideEncryption.Aes256,
                "aws:kms" => AutoSDKShared6df91f8a45eab833DeliveryVariant4ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => AutoSDKShared6df91f8a45eab833DeliveryVariant4ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}