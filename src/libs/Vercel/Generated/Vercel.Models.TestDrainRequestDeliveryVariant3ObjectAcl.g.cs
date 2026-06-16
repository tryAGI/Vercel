
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestDrainRequestDeliveryVariant3ObjectAcl
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
    public static class TestDrainRequestDeliveryVariant3ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestDrainRequestDeliveryVariant3ObjectAcl value)
        {
            return value switch
            {
                TestDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                TestDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                TestDrainRequestDeliveryVariant3ObjectAcl.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestDrainRequestDeliveryVariant3ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "bucket-owner-full-control" => TestDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => TestDrainRequestDeliveryVariant3ObjectAcl.BucketOwnerRead,
                "private" => TestDrainRequestDeliveryVariant3ObjectAcl.Private,
                _ => null,
            };
        }
    }
}