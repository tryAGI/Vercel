
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf9b373cd1ded5c73Type
    {
        /// <summary>
        ///
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedf9b373cd1ded5c73TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf9b373cd1ded5c73Type value)
        {
            return value switch
            {
                AutoSDKSharedf9b373cd1ded5c73Type.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf9b373cd1ded5c73Type? ToEnum(string value)
        {
            return value switch
            {
                "object" => AutoSDKSharedf9b373cd1ded5c73Type.Object,
                _ => null,
            };
        }
    }
}