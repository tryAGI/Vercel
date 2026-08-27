
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl
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
    public static class GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.Private => "private",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.PublicRead => "public-read",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.Private,
                "public-read" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}