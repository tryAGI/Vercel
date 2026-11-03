
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl
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
    public static class AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.Private => "private",
                AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.PublicRead => "public-read",
                AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.Private,
                "public-read" => AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => AutoSDKShared56f06376e757011bDeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}