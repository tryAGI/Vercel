
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl
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
    public static class UpdateDrainResponseVariant1DeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.Private => "private",
                UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.PublicRead => "public-read",
                UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.Private,
                "public-read" => UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => UpdateDrainResponseVariant1DeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}