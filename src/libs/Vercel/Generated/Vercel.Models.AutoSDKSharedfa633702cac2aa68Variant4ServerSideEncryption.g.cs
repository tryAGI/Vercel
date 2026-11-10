
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa633702cac2aa68Variant4ServerSideEncryption
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
    public static class AutoSDKSharedfa633702cac2aa68Variant4ServerSideEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa633702cac2aa68Variant4ServerSideEncryption value)
        {
            return value switch
            {
                AutoSDKSharedfa633702cac2aa68Variant4ServerSideEncryption.Aes256 => "AES256",
                AutoSDKSharedfa633702cac2aa68Variant4ServerSideEncryption.Aws_kms => "aws:kms",
                AutoSDKSharedfa633702cac2aa68Variant4ServerSideEncryption.Aws_kms_dsse => "aws:kms:dsse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa633702cac2aa68Variant4ServerSideEncryption? ToEnum(string value)
        {
            return value switch
            {
                "AES256" => AutoSDKSharedfa633702cac2aa68Variant4ServerSideEncryption.Aes256,
                "aws:kms" => AutoSDKSharedfa633702cac2aa68Variant4ServerSideEncryption.Aws_kms,
                "aws:kms:dsse" => AutoSDKSharedfa633702cac2aa68Variant4ServerSideEncryption.Aws_kms_dsse,
                _ => null,
            };
        }
    }
}