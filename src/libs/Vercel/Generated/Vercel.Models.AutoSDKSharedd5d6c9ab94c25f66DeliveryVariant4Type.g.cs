
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4Type value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4Type.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "s3" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4Type.S3,
                _ => null,
            };
        }
    }
}