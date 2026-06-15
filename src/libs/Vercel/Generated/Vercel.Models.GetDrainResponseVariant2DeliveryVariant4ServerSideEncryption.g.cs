
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2DeliveryVariant4ServerSideEncryption
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
    public static class GetDrainResponseVariant2DeliveryVariant4ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2DeliveryVariant4ServerSideEncryption value)
        {
            return value switch
            {
                GetDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aes256 => "AES256",
                GetDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms => "aws:kms",
                GetDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2DeliveryVariant4ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => GetDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aes256,
                "aws:kms" => GetDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => GetDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}