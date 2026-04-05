
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Invitation status for the user scoped bypass.
    /// </summary>
    public enum PatchUrlProtectionBypassRequestVariant2ScopeAccess
    {
        /// <summary>
        /// 
        /// </summary>
        Denied,
        /// <summary>
        /// 
        /// </summary>
        Granted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchUrlProtectionBypassRequestVariant2ScopeAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchUrlProtectionBypassRequestVariant2ScopeAccess value)
        {
            return value switch
            {
                PatchUrlProtectionBypassRequestVariant2ScopeAccess.Denied => "denied",
                PatchUrlProtectionBypassRequestVariant2ScopeAccess.Granted => "granted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchUrlProtectionBypassRequestVariant2ScopeAccess? ToEnum(string value)
        {
            return value switch
            {
                "denied" => PatchUrlProtectionBypassRequestVariant2ScopeAccess.Denied,
                "granted" => PatchUrlProtectionBypassRequestVariant2ScopeAccess.Granted,
                _ => null,
            };
        }
    }
}