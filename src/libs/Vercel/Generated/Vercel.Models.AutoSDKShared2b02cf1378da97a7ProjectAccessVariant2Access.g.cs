
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2b02cf1378da97a7ProjectAccessVariant2Access
    {
        /// <summary>
        ///
        /// </summary>
        Some,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2b02cf1378da97a7ProjectAccessVariant2AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2b02cf1378da97a7ProjectAccessVariant2Access value)
        {
            return value switch
            {
                AutoSDKShared2b02cf1378da97a7ProjectAccessVariant2Access.Some => "some",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2b02cf1378da97a7ProjectAccessVariant2Access? ToEnum(string value)
        {
            return value switch
            {
                "some" => AutoSDKShared2b02cf1378da97a7ProjectAccessVariant2Access.Some,
                _ => null,
            };
        }
    }
}