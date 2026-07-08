
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant11Id
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
    public static class UpdateFirewallConfigRequestVariant11IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant11Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant11Id.Gen => "gen",
                UpdateFirewallConfigRequestVariant11Id.Java => "java",
                UpdateFirewallConfigRequestVariant11Id.Lfi => "lfi",
                UpdateFirewallConfigRequestVariant11Id.Ma => "ma",
                UpdateFirewallConfigRequestVariant11Id.Php => "php",
                UpdateFirewallConfigRequestVariant11Id.Rce => "rce",
                UpdateFirewallConfigRequestVariant11Id.Rfi => "rfi",
                UpdateFirewallConfigRequestVariant11Id.Sd => "sd",
                UpdateFirewallConfigRequestVariant11Id.Sf => "sf",
                UpdateFirewallConfigRequestVariant11Id.Sqli => "sqli",
                UpdateFirewallConfigRequestVariant11Id.Xss => "xss",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant11Id? ToEnum(string value)
        {
            return value switch
            {
                "gen" => UpdateFirewallConfigRequestVariant11Id.Gen,
                "java" => UpdateFirewallConfigRequestVariant11Id.Java,
                "lfi" => UpdateFirewallConfigRequestVariant11Id.Lfi,
                "ma" => UpdateFirewallConfigRequestVariant11Id.Ma,
                "php" => UpdateFirewallConfigRequestVariant11Id.Php,
                "rce" => UpdateFirewallConfigRequestVariant11Id.Rce,
                "rfi" => UpdateFirewallConfigRequestVariant11Id.Rfi,
                "sd" => UpdateFirewallConfigRequestVariant11Id.Sd,
                "sf" => UpdateFirewallConfigRequestVariant11Id.Sf,
                "sqli" => UpdateFirewallConfigRequestVariant11Id.Sqli,
                "xss" => UpdateFirewallConfigRequestVariant11Id.Xss,
                _ => null,
            };
        }
    }
}