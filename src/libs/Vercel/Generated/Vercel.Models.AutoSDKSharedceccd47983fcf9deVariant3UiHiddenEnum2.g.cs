
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedceccd47983fcf9deVariant3UiHiddenEnum2
    {
        /// <summary>
        ///
        /// </summary>
        Create,
        /// <summary>
        ///
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedceccd47983fcf9deVariant3UiHiddenEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedceccd47983fcf9deVariant3UiHiddenEnum2 value)
        {
            return value switch
            {
                AutoSDKSharedceccd47983fcf9deVariant3UiHiddenEnum2.Create => "create",
                AutoSDKSharedceccd47983fcf9deVariant3UiHiddenEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedceccd47983fcf9deVariant3UiHiddenEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => AutoSDKSharedceccd47983fcf9deVariant3UiHiddenEnum2.Create,
                "update" => AutoSDKSharedceccd47983fcf9deVariant3UiHiddenEnum2.Update,
                _ => null,
            };
        }
    }
}