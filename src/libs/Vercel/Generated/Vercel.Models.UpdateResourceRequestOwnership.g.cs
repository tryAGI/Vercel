
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateResourceRequestOwnership
    {
        /// <summary>
        /// 
        /// </summary>
        Linked,
        /// <summary>
        /// 
        /// </summary>
        Owned,
        /// <summary>
        /// 
        /// </summary>
        Sandbox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateResourceRequestOwnershipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResourceRequestOwnership value)
        {
            return value switch
            {
                UpdateResourceRequestOwnership.Linked => "linked",
                UpdateResourceRequestOwnership.Owned => "owned",
                UpdateResourceRequestOwnership.Sandbox => "sandbox",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResourceRequestOwnership? ToEnum(string value)
        {
            return value switch
            {
                "linked" => UpdateResourceRequestOwnership.Linked,
                "owned" => UpdateResourceRequestOwnership.Owned,
                "sandbox" => UpdateResourceRequestOwnership.Sandbox,
                _ => null,
            };
        }
    }
}