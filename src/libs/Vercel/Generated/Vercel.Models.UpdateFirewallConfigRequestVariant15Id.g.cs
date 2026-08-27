
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant15Id
    {
        /// <summary>
        ///
        /// </summary>
        Gen,
        /// <summary>
        ///
        /// </summary>
        Java,
        /// <summary>
        ///
        /// </summary>
        Lfi,
        /// <summary>
        ///
        /// </summary>
        Ma,
        /// <summary>
        ///
        /// </summary>
        Php,
        /// <summary>
        ///
        /// </summary>
        Rce,
        /// <summary>
        ///
        /// </summary>
        Rfi,
        /// <summary>
        ///
        /// </summary>
        Sd,
        /// <summary>
        ///
        /// </summary>
        Sf,
        /// <summary>
        ///
        /// </summary>
        Sqli,
        /// <summary>
        ///
        /// </summary>
        Xss,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant15IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant15Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant15Id.Gen => "gen",
                UpdateFirewallConfigRequestVariant15Id.Java => "java",
                UpdateFirewallConfigRequestVariant15Id.Lfi => "lfi",
                UpdateFirewallConfigRequestVariant15Id.Ma => "ma",
                UpdateFirewallConfigRequestVariant15Id.Php => "php",
                UpdateFirewallConfigRequestVariant15Id.Rce => "rce",
                UpdateFirewallConfigRequestVariant15Id.Rfi => "rfi",
                UpdateFirewallConfigRequestVariant15Id.Sd => "sd",
                UpdateFirewallConfigRequestVariant15Id.Sf => "sf",
                UpdateFirewallConfigRequestVariant15Id.Sqli => "sqli",
                UpdateFirewallConfigRequestVariant15Id.Xss => "xss",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant15Id? ToEnum(string value)
        {
            return value switch
            {
                "gen" => UpdateFirewallConfigRequestVariant15Id.Gen,
                "java" => UpdateFirewallConfigRequestVariant15Id.Java,
                "lfi" => UpdateFirewallConfigRequestVariant15Id.Lfi,
                "ma" => UpdateFirewallConfigRequestVariant15Id.Ma,
                "php" => UpdateFirewallConfigRequestVariant15Id.Php,
                "rce" => UpdateFirewallConfigRequestVariant15Id.Rce,
                "rfi" => UpdateFirewallConfigRequestVariant15Id.Rfi,
                "sd" => UpdateFirewallConfigRequestVariant15Id.Sd,
                "sf" => UpdateFirewallConfigRequestVariant15Id.Sf,
                "sqli" => UpdateFirewallConfigRequestVariant15Id.Sqli,
                "xss" => UpdateFirewallConfigRequestVariant15Id.Xss,
                _ => null,
            };
        }
    }
}