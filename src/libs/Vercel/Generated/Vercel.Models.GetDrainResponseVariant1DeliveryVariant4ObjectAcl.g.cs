
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant1DeliveryVariant4ObjectAcl
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
    public static class GetDrainResponseVariant1DeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant1DeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                GetDrainResponseVariant1DeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                GetDrainResponseVariant1DeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                GetDrainResponseVariant1DeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                GetDrainResponseVariant1DeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                GetDrainResponseVariant1DeliveryVariant4ObjectAcl.Private => "private",
                GetDrainResponseVariant1DeliveryVariant4ObjectAcl.PublicRead => "public-read",
                GetDrainResponseVariant1DeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant1DeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => GetDrainResponseVariant1DeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => GetDrainResponseVariant1DeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => GetDrainResponseVariant1DeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => GetDrainResponseVariant1DeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => GetDrainResponseVariant1DeliveryVariant4ObjectAcl.Private,
                "public-read" => GetDrainResponseVariant1DeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => GetDrainResponseVariant1DeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}