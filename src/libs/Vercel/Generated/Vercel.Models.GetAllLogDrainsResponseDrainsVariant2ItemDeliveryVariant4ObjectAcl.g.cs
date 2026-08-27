
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl
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
    public static class GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.Private => "private",
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.PublicRead => "public-read",
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.Private,
                "public-read" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}