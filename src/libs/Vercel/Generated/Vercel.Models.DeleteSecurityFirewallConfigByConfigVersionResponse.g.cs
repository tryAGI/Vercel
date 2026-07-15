
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteSecurityFirewallConfigByConfigVersionResponse
    {
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteSecurityFirewallConfigByConfigVersionResponseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSecurityFirewallConfigByConfigVersionResponse value)
        {
            return value switch
            {
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSecurityFirewallConfigByConfigVersionResponse? ToEnum(string value)
        {
            return value switch
            {
                _ => null,
            };
        }
    }
}