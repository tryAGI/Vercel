
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ServerSideEncryption
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
    public static class AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ServerSideEncryption value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ServerSideEncryption.Aes256 => "AES256",
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ServerSideEncryption.Aws_kms => "aws:kms",
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ServerSideEncryption.Aes256,
                "aws:kms" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}