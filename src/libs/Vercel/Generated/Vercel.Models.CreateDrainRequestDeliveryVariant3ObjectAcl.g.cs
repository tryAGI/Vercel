
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainRequestDeliveryVariant3ObjectAcl
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
    public static class CreateDrainRequestDeliveryVariant3ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestDeliveryVariant3ObjectAcl value)
        {
            return value switch
            {
                CreateDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                CreateDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                CreateDrainRequestDeliveryVariant3ObjectAcl.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestDeliveryVariant3ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "bucket-owner-full-control" => CreateDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => CreateDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerRead,
                "private" => CreateDrainRequestDeliveryVariant3ObjectAcl.Private,
                _ => null,
            };
        }
    }
}