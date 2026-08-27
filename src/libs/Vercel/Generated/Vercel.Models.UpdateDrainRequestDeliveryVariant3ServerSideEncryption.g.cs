
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Value: AES256
    /// </summary>
    public enum UpdateDrainRequestDeliveryVariant3ServerSideEncryption
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
    public static class UpdateDrainRequestDeliveryVariant3ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestDeliveryVariant3ServerSideEncryption value)
        {
            return value switch
            {
                UpdateDrainRequestDeliveryVariant3ServerSideEncryption.Aes256 => "AES256",
                UpdateDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms => "aws:kms",
                UpdateDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestDeliveryVariant3ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => UpdateDrainRequestDeliveryVariant3ServerSideEncryption.Aes256,
                "aws:kms" => UpdateDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => UpdateDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}