
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl
    {
        /// <summary>
        ///
        /// </summary>
        AuthenticatedRead,
        /// <summary>
        ///
        /// </summary>
        AwsExecRead,
        /// <summary>
        ///
        /// </summary>
        BucketOwnerFullControl,
        /// <summary>
        ///
        /// </summary>
        BucketOwnerRead,
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        PublicRead,
        /// <summary>
        ///
        /// </summary>
        PublicReadWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfa633702cac2aa68Variant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl value)
        {
            return value switch
            {
                AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.AwsExecRead => "aws-exec-read",
                AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.Private => "private",
                AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.PublicRead => "public-read",
                AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.BucketOwnerRead,
                "private" => AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.Private,
                "public-read" => AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.PublicRead,
                "public-read-write" => AutoSDKSharedfa633702cac2aa68Variant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}