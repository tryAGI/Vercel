#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedc60721415ef8a2a0 : global::System.IEquatable<AutoSDKSharedc60721415ef8a2a0>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared17a9bc9c3c063edb>? Sharedfb9c9ee0e5dd70ce { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared17a9bc9c3c063edb>? Sharedfb9c9ee0e5dd70ce { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedfb9c9ee0e5dd70ce))]
#endif
        public bool IsSharedfb9c9ee0e5dd70ce => Sharedfb9c9ee0e5dd70ce != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedfb9c9ee0e5dd70ce(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared17a9bc9c3c063edb>? value)
        {
            value = Sharedfb9c9ee0e5dd70ce;
            return IsSharedfb9c9ee0e5dd70ce;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared17a9bc9c3c063edb> PickSharedfb9c9ee0e5dd70ce() => Sharedfb9c9ee0e5dd70ce is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedfb9c9ee0e5dd70ce' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>? AutoSDKSharedc60721415ef8a2a0Variant2 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>? AutoSDKSharedc60721415ef8a2a0Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKSharedc60721415ef8a2a0Variant2))]
#endif
        public bool IsAutoSDKSharedc60721415ef8a2a0Variant2 => AutoSDKSharedc60721415ef8a2a0Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKSharedc60721415ef8a2a0Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>? value)
        {
            value = AutoSDKSharedc60721415ef8a2a0Variant2;
            return IsAutoSDKSharedc60721415ef8a2a0Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22> PickAutoSDKSharedc60721415ef8a2a0Variant2() => AutoSDKSharedc60721415ef8a2a0Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKSharedc60721415ef8a2a0Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedc60721415ef8a2a0(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22> value) => new AutoSDKSharedc60721415ef8a2a0((global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>?(AutoSDKSharedc60721415ef8a2a0 @this) => @this.AutoSDKSharedc60721415ef8a2a0Variant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc60721415ef8a2a0(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>? value)
        {
            AutoSDKSharedc60721415ef8a2a0Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedc60721415ef8a2a0 FromAutoSDKSharedc60721415ef8a2a0Variant2(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>? value) => new AutoSDKSharedc60721415ef8a2a0(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc60721415ef8a2a0(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared17a9bc9c3c063edb>? sharedfb9c9ee0e5dd70ce,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>? autoSDKSharedc60721415ef8a2a0Variant2
            )
        {
            Sharedfb9c9ee0e5dd70ce = sharedfb9c9ee0e5dd70ce;
            AutoSDKSharedc60721415ef8a2a0Variant2 = autoSDKSharedc60721415ef8a2a0Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKSharedc60721415ef8a2a0Variant2 as object ??
            Sharedfb9c9ee0e5dd70ce as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedfb9c9ee0e5dd70ce?.ToString() ??
            AutoSDKSharedc60721415ef8a2a0Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedfb9c9ee0e5dd70ce && !IsAutoSDKSharedc60721415ef8a2a0Variant2 || !IsSharedfb9c9ee0e5dd70ce && IsAutoSDKSharedc60721415ef8a2a0Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared17a9bc9c3c063edb>, TResult>? sharedfb9c9ee0e5dd70ce = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>, TResult>? autoSDKSharedc60721415ef8a2a0Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedfb9c9ee0e5dd70ce is { } __value0 && sharedfb9c9ee0e5dd70ce != null)
            {
                return sharedfb9c9ee0e5dd70ce(__value0);
            }
            else if (AutoSDKSharedc60721415ef8a2a0Variant2 is { } __value1 && autoSDKSharedc60721415ef8a2a0Variant2 != null)
            {
                return autoSDKSharedc60721415ef8a2a0Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared17a9bc9c3c063edb>>? sharedfb9c9ee0e5dd70ce = null,

            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>>? autoSDKSharedc60721415ef8a2a0Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedfb9c9ee0e5dd70ce is { } __value0)
            {
                sharedfb9c9ee0e5dd70ce?.Invoke(__value0);
            }
            else if (AutoSDKSharedc60721415ef8a2a0Variant2 is { } __value1)
            {
                autoSDKSharedc60721415ef8a2a0Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared17a9bc9c3c063edb>>? sharedfb9c9ee0e5dd70ce = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>>? autoSDKSharedc60721415ef8a2a0Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedfb9c9ee0e5dd70ce is { } __value0)
            {
                sharedfb9c9ee0e5dd70ce?.Invoke(__value0);
            }
            else if (AutoSDKSharedc60721415ef8a2a0Variant2 is { } __value1)
            {
                autoSDKSharedc60721415ef8a2a0Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedfb9c9ee0e5dd70ce,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared17a9bc9c3c063edb>),
                AutoSDKSharedc60721415ef8a2a0Variant2,
                typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AutoSDKSharedc60721415ef8a2a0 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared17a9bc9c3c063edb>?>.Default.Equals(Sharedfb9c9ee0e5dd70ce, other.Sharedfb9c9ee0e5dd70ce) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedc60721415ef8a2a0Variant22>?>.Default.Equals(AutoSDKSharedc60721415ef8a2a0Variant2, other.AutoSDKSharedc60721415ef8a2a0Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedc60721415ef8a2a0 obj1, AutoSDKSharedc60721415ef8a2a0 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedc60721415ef8a2a0>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedc60721415ef8a2a0 obj1, AutoSDKSharedc60721415ef8a2a0 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedc60721415ef8a2a0 o && Equals(o);
        }
    }
}
