
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant14Id
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
    public static class UpdateFirewallConfigRequestVariant14IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant14Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant14Id.Gen => "gen",
                UpdateFirewallConfigRequestVariant14Id.Java => "java",
                UpdateFirewallConfigRequestVariant14Id.Lfi => "lfi",
                UpdateFirewallConfigRequestVariant14Id.Ma => "ma",
                UpdateFirewallConfigRequestVariant14Id.Php => "php",
                UpdateFirewallConfigRequestVariant14Id.Rce => "rce",
                UpdateFirewallConfigRequestVariant14Id.Rfi => "rfi",
                UpdateFirewallConfigRequestVariant14Id.Sd => "sd",
                UpdateFirewallConfigRequestVariant14Id.Sf => "sf",
                UpdateFirewallConfigRequestVariant14Id.Sqli => "sqli",
                UpdateFirewallConfigRequestVariant14Id.Xss => "xss",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant14Id? ToEnum(string value)
        {
            return value switch
            {
                "gen" => UpdateFirewallConfigRequestVariant14Id.Gen,
                "java" => UpdateFirewallConfigRequestVariant14Id.Java,
                "lfi" => UpdateFirewallConfigRequestVariant14Id.Lfi,
                "ma" => UpdateFirewallConfigRequestVariant14Id.Ma,
                "php" => UpdateFirewallConfigRequestVariant14Id.Php,
                "rce" => UpdateFirewallConfigRequestVariant14Id.Rce,
                "rfi" => UpdateFirewallConfigRequestVariant14Id.Rfi,
                "sd" => UpdateFirewallConfigRequestVariant14Id.Sd,
                "sf" => UpdateFirewallConfigRequestVariant14Id.Sf,
                "sqli" => UpdateFirewallConfigRequestVariant14Id.Sqli,
                "xss" => UpdateFirewallConfigRequestVariant14Id.Xss,
                _ => null,
            };
        }
    }
}