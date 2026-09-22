
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Type value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Type.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "s3" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Type.S3,
                _ => null,
            };
        }
    }
}