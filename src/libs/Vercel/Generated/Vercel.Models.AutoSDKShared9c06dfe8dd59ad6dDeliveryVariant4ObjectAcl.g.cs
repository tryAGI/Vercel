
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl
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
    public static class AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.Private => "private",
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.PublicRead => "public-read",
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.Private,
                "public-read" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}