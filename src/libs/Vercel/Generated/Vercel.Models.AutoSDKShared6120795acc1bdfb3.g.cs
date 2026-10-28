#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared6120795acc1bdfb3 : global::System.IEquatable<AutoSDKShared6120795acc1bdfb3>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1? AutoSDKShared6120795acc1bdfb3Variant1 { get; init; }
#else
        public global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1? AutoSDKShared6120795acc1bdfb3Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared6120795acc1bdfb3Variant1))]
#endif
        public bool IsAutoSDKShared6120795acc1bdfb3Variant1 => AutoSDKShared6120795acc1bdfb3Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared6120795acc1bdfb3Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1? value)
        {
            value = AutoSDKShared6120795acc1bdfb3Variant1;
            return IsAutoSDKShared6120795acc1bdfb3Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1 PickAutoSDKShared6120795acc1bdfb3Variant1() => AutoSDKShared6120795acc1bdfb3Variant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared6120795acc1bdfb3Variant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2? AutoSDKShared6120795acc1bdfb3Variant2 { get; init; }
#else
        public global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2? AutoSDKShared6120795acc1bdfb3Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared6120795acc1bdfb3Variant2))]
#endif
        public bool IsAutoSDKShared6120795acc1bdfb3Variant2 => AutoSDKShared6120795acc1bdfb3Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared6120795acc1bdfb3Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2? value)
        {
            value = AutoSDKShared6120795acc1bdfb3Variant2;
            return IsAutoSDKShared6120795acc1bdfb3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2 PickAutoSDKShared6120795acc1bdfb3Variant2() => AutoSDKShared6120795acc1bdfb3Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared6120795acc1bdfb3Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared6120795acc1bdfb3(global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1 value) => new AutoSDKShared6120795acc1bdfb3((global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1?(AutoSDKShared6120795acc1bdfb3 @this) => @this.AutoSDKShared6120795acc1bdfb3Variant1;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared6120795acc1bdfb3(global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1? value)
        {
            AutoSDKShared6120795acc1bdfb3Variant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared6120795acc1bdfb3 FromAutoSDKShared6120795acc1bdfb3Variant1(global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1? value) => new AutoSDKShared6120795acc1bdfb3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared6120795acc1bdfb3(global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2 value) => new AutoSDKShared6120795acc1bdfb3((global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2?(AutoSDKShared6120795acc1bdfb3 @this) => @this.AutoSDKShared6120795acc1bdfb3Variant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared6120795acc1bdfb3(global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2? value)
        {
            AutoSDKShared6120795acc1bdfb3Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared6120795acc1bdfb3 FromAutoSDKShared6120795acc1bdfb3Variant2(global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2? value) => new AutoSDKShared6120795acc1bdfb3(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared6120795acc1bdfb3(
            global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1? autoSDKShared6120795acc1bdfb3Variant1,
            global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2? autoSDKShared6120795acc1bdfb3Variant2
            )
        {
            AutoSDKShared6120795acc1bdfb3Variant1 = autoSDKShared6120795acc1bdfb3Variant1;
            AutoSDKShared6120795acc1bdfb3Variant2 = autoSDKShared6120795acc1bdfb3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKShared6120795acc1bdfb3Variant2 as object ??
            AutoSDKShared6120795acc1bdfb3Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AutoSDKShared6120795acc1bdfb3Variant1?.ToString() ??
            AutoSDKShared6120795acc1bdfb3Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAutoSDKShared6120795acc1bdfb3Variant1 && !IsAutoSDKShared6120795acc1bdfb3Variant2 || !IsAutoSDKShared6120795acc1bdfb3Variant1 && IsAutoSDKShared6120795acc1bdfb3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1, TResult>? autoSDKShared6120795acc1bdfb3Variant1 = null,
            global::System.Func<global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2, TResult>? autoSDKShared6120795acc1bdfb3Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKShared6120795acc1bdfb3Variant1 is { } __value0 && autoSDKShared6120795acc1bdfb3Variant1 != null)
            {
                return autoSDKShared6120795acc1bdfb3Variant1(__value0);
            }
            else if (AutoSDKShared6120795acc1bdfb3Variant2 is { } __value1 && autoSDKShared6120795acc1bdfb3Variant2 != null)
            {
                return autoSDKShared6120795acc1bdfb3Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1>? autoSDKShared6120795acc1bdfb3Variant1 = null,

            global::System.Action<global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2>? autoSDKShared6120795acc1bdfb3Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKShared6120795acc1bdfb3Variant1 is { } __value0)
            {
                autoSDKShared6120795acc1bdfb3Variant1?.Invoke(__value0);
            }
            else if (AutoSDKShared6120795acc1bdfb3Variant2 is { } __value1)
            {
                autoSDKShared6120795acc1bdfb3Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1>? autoSDKShared6120795acc1bdfb3Variant1 = null,
            global::System.Action<global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2>? autoSDKShared6120795acc1bdfb3Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKShared6120795acc1bdfb3Variant1 is { } __value0)
            {
                autoSDKShared6120795acc1bdfb3Variant1?.Invoke(__value0);
            }
            else if (AutoSDKShared6120795acc1bdfb3Variant2 is { } __value1)
            {
                autoSDKShared6120795acc1bdfb3Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoSDKShared6120795acc1bdfb3Variant1,
                typeof(global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1),
                AutoSDKShared6120795acc1bdfb3Variant2,
                typeof(global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2),
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
        public bool Equals(AutoSDKShared6120795acc1bdfb3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared6120795acc1bdfb3Variant1?>.Default.Equals(AutoSDKShared6120795acc1bdfb3Variant1, other.AutoSDKShared6120795acc1bdfb3Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2?>.Default.Equals(AutoSDKShared6120795acc1bdfb3Variant2, other.AutoSDKShared6120795acc1bdfb3Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared6120795acc1bdfb3 obj1, AutoSDKShared6120795acc1bdfb3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared6120795acc1bdfb3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared6120795acc1bdfb3 obj1, AutoSDKShared6120795acc1bdfb3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared6120795acc1bdfb3 o && Equals(o);
        }
    }
}
