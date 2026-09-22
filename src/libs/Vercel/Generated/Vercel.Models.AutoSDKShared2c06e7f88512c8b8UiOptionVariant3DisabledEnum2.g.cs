
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2c06e7f88512c8b8UiOptionVariant3DisabledEnum2
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
    public static class AutoSDKShared2c06e7f88512c8b8UiOptionVariant3DisabledEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2c06e7f88512c8b8UiOptionVariant3DisabledEnum2 value)
        {
            return value switch
            {
                AutoSDKShared2c06e7f88512c8b8UiOptionVariant3DisabledEnum2.Create => "create",
                AutoSDKShared2c06e7f88512c8b8UiOptionVariant3DisabledEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2c06e7f88512c8b8UiOptionVariant3DisabledEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => AutoSDKShared2c06e7f88512c8b8UiOptionVariant3DisabledEnum2.Create,
                "update" => AutoSDKShared2c06e7f88512c8b8UiOptionVariant3DisabledEnum2.Update,
                _ => null,
            };
        }
    }
}