#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedcf426121243a64be : global::System.IEquatable<AutoSDKSharedcf426121243a64be>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedcf426121243a64beVariant1? AutoSDKSharedcf426121243a64beVariant1 { get; init; }
#else
        public global::Vercel.AutoSDKSharedcf426121243a64beVariant1? AutoSDKSharedcf426121243a64beVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKSharedcf426121243a64beVariant1))]
#endif
        public bool IsAutoSDKSharedcf426121243a64beVariant1 => AutoSDKSharedcf426121243a64beVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKSharedcf426121243a64beVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedcf426121243a64beVariant1? value)
        {
            value = AutoSDKSharedcf426121243a64beVariant1;
            return IsAutoSDKSharedcf426121243a64beVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedcf426121243a64beVariant1 PickAutoSDKSharedcf426121243a64beVariant1() => AutoSDKSharedcf426121243a64beVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKSharedcf426121243a64beVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedcf426121243a64beVariant2? AutoSDKSharedcf426121243a64beVariant2 { get; init; }
#else
        public global::Vercel.AutoSDKSharedcf426121243a64beVariant2? AutoSDKSharedcf426121243a64beVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKSharedcf426121243a64beVariant2))]
#endif
        public bool IsAutoSDKSharedcf426121243a64beVariant2 => AutoSDKSharedcf426121243a64beVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKSharedcf426121243a64beVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedcf426121243a64beVariant2? value)
        {
            value = AutoSDKSharedcf426121243a64beVariant2;
            return IsAutoSDKSharedcf426121243a64beVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedcf426121243a64beVariant2 PickAutoSDKSharedcf426121243a64beVariant2() => AutoSDKSharedcf426121243a64beVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKSharedcf426121243a64beVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d? Sharedbd3f01cc8f6abd3d { get; init; }
#else
        public global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d? Sharedbd3f01cc8f6abd3d { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedbd3f01cc8f6abd3d))]
#endif
        public bool IsSharedbd3f01cc8f6abd3d => Sharedbd3f01cc8f6abd3d != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedbd3f01cc8f6abd3d(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d? value)
        {
            value = Sharedbd3f01cc8f6abd3d;
            return IsSharedbd3f01cc8f6abd3d;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d PickSharedbd3f01cc8f6abd3d() => Sharedbd3f01cc8f6abd3d is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedbd3f01cc8f6abd3d' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedcf426121243a64be(global::Vercel.AutoSDKSharedcf426121243a64beVariant1 value) => new AutoSDKSharedcf426121243a64be((global::Vercel.AutoSDKSharedcf426121243a64beVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedcf426121243a64beVariant1?(AutoSDKSharedcf426121243a64be @this) => @this.AutoSDKSharedcf426121243a64beVariant1;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedcf426121243a64be(global::Vercel.AutoSDKSharedcf426121243a64beVariant1? value)
        {
            AutoSDKSharedcf426121243a64beVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedcf426121243a64be FromAutoSDKSharedcf426121243a64beVariant1(global::Vercel.AutoSDKSharedcf426121243a64beVariant1? value) => new AutoSDKSharedcf426121243a64be(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedcf426121243a64be(global::Vercel.AutoSDKSharedcf426121243a64beVariant2 value) => new AutoSDKSharedcf426121243a64be((global::Vercel.AutoSDKSharedcf426121243a64beVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedcf426121243a64beVariant2?(AutoSDKSharedcf426121243a64be @this) => @this.AutoSDKSharedcf426121243a64beVariant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedcf426121243a64be(global::Vercel.AutoSDKSharedcf426121243a64beVariant2? value)
        {
            AutoSDKSharedcf426121243a64beVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedcf426121243a64be FromAutoSDKSharedcf426121243a64beVariant2(global::Vercel.AutoSDKSharedcf426121243a64beVariant2? value) => new AutoSDKSharedcf426121243a64be(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedcf426121243a64be(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d value) => new AutoSDKSharedcf426121243a64be((global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d?(AutoSDKSharedcf426121243a64be @this) => @this.Sharedbd3f01cc8f6abd3d;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedcf426121243a64be(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d? value)
        {
            Sharedbd3f01cc8f6abd3d = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedcf426121243a64be FromSharedbd3f01cc8f6abd3d(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d? value) => new AutoSDKSharedcf426121243a64be(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedcf426121243a64be(
            global::Vercel.AutoSDKSharedcf426121243a64beVariant1? autoSDKSharedcf426121243a64beVariant1,
            global::Vercel.AutoSDKSharedcf426121243a64beVariant2? autoSDKSharedcf426121243a64beVariant2,
            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d? sharedbd3f01cc8f6abd3d
            )
        {
            AutoSDKSharedcf426121243a64beVariant1 = autoSDKSharedcf426121243a64beVariant1;
            AutoSDKSharedcf426121243a64beVariant2 = autoSDKSharedcf426121243a64beVariant2;
            Sharedbd3f01cc8f6abd3d = sharedbd3f01cc8f6abd3d;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedbd3f01cc8f6abd3d as object ??
            AutoSDKSharedcf426121243a64beVariant2 as object ??
            AutoSDKSharedcf426121243a64beVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AutoSDKSharedcf426121243a64beVariant1?.ToString() ??
            AutoSDKSharedcf426121243a64beVariant2?.ToString() ??
            Sharedbd3f01cc8f6abd3d?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAutoSDKSharedcf426121243a64beVariant1 && !IsAutoSDKSharedcf426121243a64beVariant2 && !IsSharedbd3f01cc8f6abd3d || !IsAutoSDKSharedcf426121243a64beVariant1 && IsAutoSDKSharedcf426121243a64beVariant2 && !IsSharedbd3f01cc8f6abd3d || !IsAutoSDKSharedcf426121243a64beVariant1 && !IsAutoSDKSharedcf426121243a64beVariant2 && IsSharedbd3f01cc8f6abd3d;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharedcf426121243a64beVariant1, TResult>? autoSDKSharedcf426121243a64beVariant1 = null,
            global::System.Func<global::Vercel.AutoSDKSharedcf426121243a64beVariant2, TResult>? autoSDKSharedcf426121243a64beVariant2 = null,
            global::System.Func<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d?, TResult>? sharedbd3f01cc8f6abd3d = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKSharedcf426121243a64beVariant1 is { } __value0 && autoSDKSharedcf426121243a64beVariant1 != null)
            {
                return autoSDKSharedcf426121243a64beVariant1(__value0);
            }
            else if (AutoSDKSharedcf426121243a64beVariant2 is { } __value1 && autoSDKSharedcf426121243a64beVariant2 != null)
            {
                return autoSDKSharedcf426121243a64beVariant2(__value1);
            }
            else if (Sharedbd3f01cc8f6abd3d is { } __value2 && sharedbd3f01cc8f6abd3d != null)
            {
                return sharedbd3f01cc8f6abd3d(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKSharedcf426121243a64beVariant1>? autoSDKSharedcf426121243a64beVariant1 = null,

            global::System.Action<global::Vercel.AutoSDKSharedcf426121243a64beVariant2>? autoSDKSharedcf426121243a64beVariant2 = null,

            global::System.Action<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d?>? sharedbd3f01cc8f6abd3d = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKSharedcf426121243a64beVariant1 is { } __value0)
            {
                autoSDKSharedcf426121243a64beVariant1?.Invoke(__value0);
            }
            else if (AutoSDKSharedcf426121243a64beVariant2 is { } __value1)
            {
                autoSDKSharedcf426121243a64beVariant2?.Invoke(__value1);
            }
            else if (Sharedbd3f01cc8f6abd3d is { } __value2)
            {
                sharedbd3f01cc8f6abd3d?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKSharedcf426121243a64beVariant1>? autoSDKSharedcf426121243a64beVariant1 = null,
            global::System.Action<global::Vercel.AutoSDKSharedcf426121243a64beVariant2>? autoSDKSharedcf426121243a64beVariant2 = null,
            global::System.Action<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d?>? sharedbd3f01cc8f6abd3d = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKSharedcf426121243a64beVariant1 is { } __value0)
            {
                autoSDKSharedcf426121243a64beVariant1?.Invoke(__value0);
            }
            else if (AutoSDKSharedcf426121243a64beVariant2 is { } __value1)
            {
                autoSDKSharedcf426121243a64beVariant2?.Invoke(__value1);
            }
            else if (Sharedbd3f01cc8f6abd3d is { } __value2)
            {
                sharedbd3f01cc8f6abd3d?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoSDKSharedcf426121243a64beVariant1,
                typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant1),
                AutoSDKSharedcf426121243a64beVariant2,
                typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant2),
                Sharedbd3f01cc8f6abd3d,
                typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d),
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
        public bool Equals(AutoSDKSharedcf426121243a64be other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedcf426121243a64beVariant1?>.Default.Equals(AutoSDKSharedcf426121243a64beVariant1, other.AutoSDKSharedcf426121243a64beVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedcf426121243a64beVariant2?>.Default.Equals(AutoSDKSharedcf426121243a64beVariant2, other.AutoSDKSharedcf426121243a64beVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d?>.Default.Equals(Sharedbd3f01cc8f6abd3d, other.Sharedbd3f01cc8f6abd3d)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedcf426121243a64be obj1, AutoSDKSharedcf426121243a64be obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedcf426121243a64be>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedcf426121243a64be obj1, AutoSDKSharedcf426121243a64be obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedcf426121243a64be o && Equals(o);
        }
    }
}
