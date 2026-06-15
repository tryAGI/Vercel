
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption
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
    public static class GetDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aes256 => "AES256",
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aws_kms => "aws:kms",
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aes256,
                "aws:kms" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant4ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}