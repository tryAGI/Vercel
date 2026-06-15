
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainRequestDeliveryVariant3ObjectAcl
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainRequestDeliveryVariant3ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestDeliveryVariant3ObjectAcl value)
        {
            return value switch
            {
                UpdateDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                UpdateDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                UpdateDrainRequestDeliveryVariant3ObjectAcl.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestDeliveryVariant3ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "bucket-owner-full-control" => UpdateDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => UpdateDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerRead,
                "private" => UpdateDrainRequestDeliveryVariant3ObjectAcl.Private,
                _ => null,
            };
        }
    }
}