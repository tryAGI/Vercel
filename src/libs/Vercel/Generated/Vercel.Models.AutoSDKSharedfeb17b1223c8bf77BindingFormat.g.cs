
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKSharedfeb17b1223c8bf77BindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfeb17b1223c8bf77BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfeb17b1223c8bf77BindingFormat value)
        {
            return value switch
            {
                AutoSDKSharedfeb17b1223c8bf77BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfeb17b1223c8bf77BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKSharedfeb17b1223c8bf77BindingFormat.Url,
                _ => null,
            };
        }
    }
}