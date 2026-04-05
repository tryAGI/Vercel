
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchUrlProtectionBypassRequestVariant3OverrideAction
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Revoke,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchUrlProtectionBypassRequestVariant3OverrideActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchUrlProtectionBypassRequestVariant3OverrideAction value)
        {
            return value switch
            {
                PatchUrlProtectionBypassRequestVariant3OverrideAction.Create => "create",
                PatchUrlProtectionBypassRequestVariant3OverrideAction.Revoke => "revoke",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchUrlProtectionBypassRequestVariant3OverrideAction? ToEnum(string value)
        {
            return value switch
            {
                "create" => PatchUrlProtectionBypassRequestVariant3OverrideAction.Create,
                "revoke" => PatchUrlProtectionBypassRequestVariant3OverrideAction.Revoke,
                _ => null,
            };
        }
    }
}