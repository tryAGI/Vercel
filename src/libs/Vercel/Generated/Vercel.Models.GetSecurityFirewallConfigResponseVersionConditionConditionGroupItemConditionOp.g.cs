
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp
    {
        /// <summary>
        ///
        /// </summary>
        Eq,
        /// <summary>
        ///
        /// </summary>
        Ex,
        /// <summary>
        ///
        /// </summary>
        Gt,
        /// <summary>
        ///
        /// </summary>
        Gte,
        /// <summary>
        ///
        /// </summary>
        Inc,
        /// <summary>
        ///
        /// </summary>
        List,
        /// <summary>
        ///
        /// </summary>
        Lt,
        /// <summary>
        ///
        /// </summary>
        Lte,
        /// <summary>
        ///
        /// </summary>
        Neq,
        /// <summary>
        ///
        /// </summary>
        Nex,
        /// <summary>
        ///
        /// </summary>
        Ninc,
        /// <summary>
        ///
        /// </summary>
        Pre,
        /// <summary>
        ///
        /// </summary>
        Re,
        /// <summary>
        ///
        /// </summary>
        Sub,
        /// <summary>
        ///
        /// </summary>
        Suf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}