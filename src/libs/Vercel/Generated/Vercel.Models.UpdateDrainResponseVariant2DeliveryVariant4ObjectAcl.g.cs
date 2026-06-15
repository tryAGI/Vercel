
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl
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
    public static class UpdateDrainResponseVariant2DeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.Private => "private",
                UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.PublicRead => "public-read",
                UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.Private,
                "public-read" => UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => UpdateDrainResponseVariant2DeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}