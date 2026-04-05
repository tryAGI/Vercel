
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddBypassIpResponseVariant2ResultItemAction
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
    public static class AddBypassIpResponseVariant2ResultItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddBypassIpResponseVariant2ResultItemAction value)
        {
            return value switch
            {
                AddBypassIpResponseVariant2ResultItemAction.Block => "block",
                AddBypassIpResponseVariant2ResultItemAction.Bypass => "bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddBypassIpResponseVariant2ResultItemAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => AddBypassIpResponseVariant2ResultItemAction.Block,
                "bypass" => AddBypassIpResponseVariant2ResultItemAction.Bypass,
                _ => null,
            };
        }
    }
}