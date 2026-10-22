
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl
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
    public static class AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.Private => "private",
                AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.PublicRead => "public-read",
                AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.Private,
                "public-read" => AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => AutoSDKShared6df91f8a45eab833DeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}