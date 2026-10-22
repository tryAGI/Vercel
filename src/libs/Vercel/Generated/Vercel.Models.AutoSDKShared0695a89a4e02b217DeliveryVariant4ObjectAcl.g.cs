
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl
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
    public static class AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.Private => "private",
                AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.PublicRead => "public-read",
                AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.Private,
                "public-read" => AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => AutoSDKShared0695a89a4e02b217DeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}