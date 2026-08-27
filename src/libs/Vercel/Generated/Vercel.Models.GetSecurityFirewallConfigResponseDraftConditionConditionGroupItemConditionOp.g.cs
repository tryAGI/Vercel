
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp
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
    public static class GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}