
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2DeliveryVariant4ServerSideEncryption
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
    public static class CreateDrainResponseVariant2DeliveryVariant4ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2DeliveryVariant4ServerSideEncryption value)
        {
            return value switch
            {
                CreateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aes256 => "AES256",
                CreateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms => "aws:kms",
                CreateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2DeliveryVariant4ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => CreateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aes256,
                "aws:kms" => CreateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => CreateDrainResponseVariant2DeliveryVariant4ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}