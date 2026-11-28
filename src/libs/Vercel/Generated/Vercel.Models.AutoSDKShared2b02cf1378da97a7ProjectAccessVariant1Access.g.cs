
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1Access
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1Access value)
        {
            return value switch
            {
                AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1Access.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1Access? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1Access.All,
                _ => null,
            };
        }
    }
}