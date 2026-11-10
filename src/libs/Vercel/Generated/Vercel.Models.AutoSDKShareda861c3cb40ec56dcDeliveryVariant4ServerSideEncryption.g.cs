
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ServerSideEncryption
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
    public static class AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ServerSideEncryption value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ServerSideEncryption.Aes256 => "AES256",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ServerSideEncryption.Aws_kms => "aws:kms",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ServerSideEncryption.Aes256,
                "aws:kms" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}