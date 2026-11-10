
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8DeliveryVariant4ServerSideEncryption
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
    public static class AutoSDKShared8df5bff0bb4332b8DeliveryVariant4ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8DeliveryVariant4ServerSideEncryption value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8DeliveryVariant4ServerSideEncryption.Aes256 => "AES256",
                AutoSDKShared8df5bff0bb4332b8DeliveryVariant4ServerSideEncryption.Aws_kms => "aws:kms",
                AutoSDKShared8df5bff0bb4332b8DeliveryVariant4ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8DeliveryVariant4ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => AutoSDKShared8df5bff0bb4332b8DeliveryVariant4ServerSideEncryption.Aes256,
                "aws:kms" => AutoSDKShared8df5bff0bb4332b8DeliveryVariant4ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => AutoSDKShared8df5bff0bb4332b8DeliveryVariant4ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}