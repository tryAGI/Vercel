
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd2d51fdc45c5e627TypeName
    {
        /// <summary>
        ///
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd2d51fdc45c5e627TypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd2d51fdc45c5e627TypeName value)
        {
            return value switch
            {
                AutoSDKSharedd2d51fdc45c5e627TypeName.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd2d51fdc45c5e627TypeName? ToEnum(string value)
        {
            return value switch
            {
                "segment" => AutoSDKSharedd2d51fdc45c5e627TypeName.Segment,
                _ => null,
            };
        }
    }
}