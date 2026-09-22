
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl
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
    public static class AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.Private => "private",
                AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.PublicRead => "public-read",
                AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.Private,
                "public-read" => AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => AutoSDKShared383028c008cc4ae0DeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}