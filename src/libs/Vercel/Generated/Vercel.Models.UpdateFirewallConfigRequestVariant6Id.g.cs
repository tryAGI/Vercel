
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant6Id
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
    public static class UpdateFirewallConfigRequestVariant6IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant6Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant6Id.Gen => "gen",
                UpdateFirewallConfigRequestVariant6Id.Java => "java",
                UpdateFirewallConfigRequestVariant6Id.Lfi => "lfi",
                UpdateFirewallConfigRequestVariant6Id.Ma => "ma",
                UpdateFirewallConfigRequestVariant6Id.Php => "php",
                UpdateFirewallConfigRequestVariant6Id.Rce => "rce",
                UpdateFirewallConfigRequestVariant6Id.Rfi => "rfi",
                UpdateFirewallConfigRequestVariant6Id.Sd => "sd",
                UpdateFirewallConfigRequestVariant6Id.Sf => "sf",
                UpdateFirewallConfigRequestVariant6Id.Sqli => "sqli",
                UpdateFirewallConfigRequestVariant6Id.Xss => "xss",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant6Id? ToEnum(string value)
        {
            return value switch
            {
                "gen" => UpdateFirewallConfigRequestVariant6Id.Gen,
                "java" => UpdateFirewallConfigRequestVariant6Id.Java,
                "lfi" => UpdateFirewallConfigRequestVariant6Id.Lfi,
                "ma" => UpdateFirewallConfigRequestVariant6Id.Ma,
                "php" => UpdateFirewallConfigRequestVariant6Id.Php,
                "rce" => UpdateFirewallConfigRequestVariant6Id.Rce,
                "rfi" => UpdateFirewallConfigRequestVariant6Id.Rfi,
                "sd" => UpdateFirewallConfigRequestVariant6Id.Sd,
                "sf" => UpdateFirewallConfigRequestVariant6Id.Sf,
                "sqli" => UpdateFirewallConfigRequestVariant6Id.Sqli,
                "xss" => UpdateFirewallConfigRequestVariant6Id.Xss,
                _ => null,
            };
        }
    }
}