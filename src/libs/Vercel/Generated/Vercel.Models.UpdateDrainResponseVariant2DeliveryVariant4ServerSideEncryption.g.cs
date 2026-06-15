
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2DeliveryVariant4ServerSideEncryption
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
    public static class UpdateDrainResponseVariant2DeliveryVariant4ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2DeliveryVariant4ServerSideEncryption value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aes256 => "AES256",
                UpdateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms => "aws:kms",
                UpdateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2DeliveryVariant4ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => UpdateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aes256,
                "aws:kms" => UpdateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => UpdateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}