
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Recognition context that should remain visible in a compact feed row.
    /// </summary>
    public enum UserEventDetailDisplay
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventDetailDisplayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventDetailDisplay value)
        {
            return value switch
            {
                UserEventDetailDisplay.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventDetailDisplay? ToEnum(string value)
        {
            return value switch
            {
                "inline" => UserEventDetailDisplay.Inline,
                _ => null,
            };
        }
    }
}