
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8dbad85779e5c1fbTransformVariant2Op
    {
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8dbad85779e5c1fbTransformVariant2OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8dbad85779e5c1fbTransformVariant2Op value)
        {
            return value switch
            {
                AutoSDKShared8dbad85779e5c1fbTransformVariant2Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8dbad85779e5c1fbTransformVariant2Op? ToEnum(string value)
        {
            return value switch
            {
                "set" => AutoSDKShared8dbad85779e5c1fbTransformVariant2Op.Set,
                _ => null,
            };
        }
    }
}