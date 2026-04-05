
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportResourceRequestOwnership
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
    public static class ImportResourceRequestOwnershipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportResourceRequestOwnership value)
        {
            return value switch
            {
                ImportResourceRequestOwnership.Linked => "linked",
                ImportResourceRequestOwnership.Owned => "owned",
                ImportResourceRequestOwnership.Sandbox => "sandbox",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportResourceRequestOwnership? ToEnum(string value)
        {
            return value switch
            {
                "linked" => ImportResourceRequestOwnership.Linked,
                "owned" => ImportResourceRequestOwnership.Owned,
                "sandbox" => ImportResourceRequestOwnership.Sandbox,
                _ => null,
            };
        }
    }
}