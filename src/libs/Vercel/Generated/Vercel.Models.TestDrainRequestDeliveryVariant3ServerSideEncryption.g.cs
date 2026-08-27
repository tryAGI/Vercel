
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Value: AES256
    /// </summary>
    public enum TestDrainRequestDeliveryVariant3ServerSideEncryption
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
    public static class TestDrainRequestDeliveryVariant3ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestDrainRequestDeliveryVariant3ServerSideEncryption value)
        {
            return value switch
            {
                TestDrainRequestDeliveryVariant3ServerSideEncryption.Aes256 => "AES256",
                TestDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms => "aws:kms",
                TestDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestDrainRequestDeliveryVariant3ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => TestDrainRequestDeliveryVariant3ServerSideEncryption.Aes256,
                "aws:kms" => TestDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => TestDrainRequestDeliveryVariant3ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}