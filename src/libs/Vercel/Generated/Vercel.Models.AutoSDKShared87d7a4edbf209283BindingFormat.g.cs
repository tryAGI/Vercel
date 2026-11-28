
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKShared87d7a4edbf209283BindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared87d7a4edbf209283BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d7a4edbf209283BindingFormat value)
        {
            return value switch
            {
                AutoSDKShared87d7a4edbf209283BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d7a4edbf209283BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKShared87d7a4edbf209283BindingFormat.Url,
                _ => null,
            };
        }
    }
}