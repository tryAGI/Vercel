
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBypassIpResponseResultItemAction
    {
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Bypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBypassIpResponseResultItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBypassIpResponseResultItemAction value)
        {
            return value switch
            {
                GetBypassIpResponseResultItemAction.Block => "block",
                GetBypassIpResponseResultItemAction.Bypass => "bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBypassIpResponseResultItemAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => GetBypassIpResponseResultItemAction.Block,
                "bypass" => GetBypassIpResponseResultItemAction.Bypass,
                _ => null,
            };
        }
    }
}