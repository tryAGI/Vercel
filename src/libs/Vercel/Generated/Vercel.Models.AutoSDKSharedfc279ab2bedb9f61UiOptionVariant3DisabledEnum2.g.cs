
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfc279ab2bedb9f61UiOptionVariant3DisabledEnum2
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
    public static class AutoSDKSharedfc279ab2bedb9f61UiOptionVariant3DisabledEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfc279ab2bedb9f61UiOptionVariant3DisabledEnum2 value)
        {
            return value switch
            {
                AutoSDKSharedfc279ab2bedb9f61UiOptionVariant3DisabledEnum2.Create => "create",
                AutoSDKSharedfc279ab2bedb9f61UiOptionVariant3DisabledEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfc279ab2bedb9f61UiOptionVariant3DisabledEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => AutoSDKSharedfc279ab2bedb9f61UiOptionVariant3DisabledEnum2.Create,
                "update" => AutoSDKSharedfc279ab2bedb9f61UiOptionVariant3DisabledEnum2.Update,
                _ => null,
            };
        }
    }
}