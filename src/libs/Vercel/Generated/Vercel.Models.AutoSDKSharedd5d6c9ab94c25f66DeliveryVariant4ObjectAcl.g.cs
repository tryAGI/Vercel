
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl
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
    public static class AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.Private => "private",
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.PublicRead => "public-read",
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.Private,
                "public-read" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}