
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption
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
    public static class GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aes256 => "AES256",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aws_kms => "aws:kms",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aes256,
                "aws:kms" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}