
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainRequestDeliveryVariant3ServerSideEncryption
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
    public static class CreateDrainRequestDeliveryVariant3ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestDeliveryVariant3ServerSideEncryption value)
        {
            return value switch
            {
                CreateDrainRequestDeliveryVariant3ServerSideEncryption.Aes256 => "AES256",
                CreateDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms => "aws:kms",
                CreateDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestDeliveryVariant3ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => CreateDrainRequestDeliveryVariant3ServerSideEncryption.Aes256,
                "aws:kms" => CreateDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => CreateDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}