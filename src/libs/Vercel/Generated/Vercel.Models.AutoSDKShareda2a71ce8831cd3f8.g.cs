#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShareda2a71ce8831cd3f8 : global::System.IEquatable<AutoSDKShareda2a71ce8831cd3f8>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared947f69fa305d000e? Shared947f69fa305d000e { get; init; }
#else
        public global::Vercel.AutoSDKShared947f69fa305d000e? Shared947f69fa305d000e { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared947f69fa305d000e))]
#endif
        public bool IsShared947f69fa305d000e => Shared947f69fa305d000e != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared947f69fa305d000e(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared947f69fa305d000e? value)
        {
            value = Shared947f69fa305d000e;
            return IsShared947f69fa305d000e;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared947f69fa305d000e PickShared947f69fa305d000e() => Shared947f69fa305d000e is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared947f69fa305d000e' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2? AutoSDKShareda2a71ce8831cd3f8Variant2 { get; init; }
#else
        public global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2? AutoSDKShareda2a71ce8831cd3f8Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShareda2a71ce8831cd3f8Variant2))]
#endif
        public bool IsAutoSDKShareda2a71ce8831cd3f8Variant2 => AutoSDKShareda2a71ce8831cd3f8Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShareda2a71ce8831cd3f8Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2? value)
        {
            value = AutoSDKShareda2a71ce8831cd3f8Variant2;
            return IsAutoSDKShareda2a71ce8831cd3f8Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2 PickAutoSDKShareda2a71ce8831cd3f8Variant2() => AutoSDKShareda2a71ce8831cd3f8Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShareda2a71ce8831cd3f8Variant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3? AutoSDKShareda2a71ce8831cd3f8Variant3 { get; init; }
#else
        public global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3? AutoSDKShareda2a71ce8831cd3f8Variant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShareda2a71ce8831cd3f8Variant3))]
#endif
        public bool IsAutoSDKShareda2a71ce8831cd3f8Variant3 => AutoSDKShareda2a71ce8831cd3f8Variant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShareda2a71ce8831cd3f8Variant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3? value)
        {
            value = AutoSDKShareda2a71ce8831cd3f8Variant3;
            return IsAutoSDKShareda2a71ce8831cd3f8Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3 PickAutoSDKShareda2a71ce8831cd3f8Variant3() => AutoSDKShareda2a71ce8831cd3f8Variant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShareda2a71ce8831cd3f8Variant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShareda2a71ce8831cd3f8(global::Vercel.AutoSDKShared947f69fa305d000e value) => new AutoSDKShareda2a71ce8831cd3f8((global::Vercel.AutoSDKShared947f69fa305d000e?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared947f69fa305d000e?(AutoSDKShareda2a71ce8831cd3f8 @this) => @this.Shared947f69fa305d000e;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShareda2a71ce8831cd3f8(global::Vercel.AutoSDKShared947f69fa305d000e? value)
        {
            Shared947f69fa305d000e = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShareda2a71ce8831cd3f8 FromShared947f69fa305d000e(global::Vercel.AutoSDKShared947f69fa305d000e? value) => new AutoSDKShareda2a71ce8831cd3f8(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShareda2a71ce8831cd3f8(global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2 value) => new AutoSDKShareda2a71ce8831cd3f8((global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2?(AutoSDKShareda2a71ce8831cd3f8 @this) => @this.AutoSDKShareda2a71ce8831cd3f8Variant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShareda2a71ce8831cd3f8(global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2? value)
        {
            AutoSDKShareda2a71ce8831cd3f8Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShareda2a71ce8831cd3f8 FromAutoSDKShareda2a71ce8831cd3f8Variant2(global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2? value) => new AutoSDKShareda2a71ce8831cd3f8(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShareda2a71ce8831cd3f8(global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3 value) => new AutoSDKShareda2a71ce8831cd3f8((global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3?(AutoSDKShareda2a71ce8831cd3f8 @this) => @this.AutoSDKShareda2a71ce8831cd3f8Variant3;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShareda2a71ce8831cd3f8(global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3? value)
        {
            AutoSDKShareda2a71ce8831cd3f8Variant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShareda2a71ce8831cd3f8 FromAutoSDKShareda2a71ce8831cd3f8Variant3(global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3? value) => new AutoSDKShareda2a71ce8831cd3f8(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShareda2a71ce8831cd3f8(
            global::Vercel.AutoSDKShared947f69fa305d000e? shared947f69fa305d000e,
            global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2? autoSDKShareda2a71ce8831cd3f8Variant2,
            global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3? autoSDKShareda2a71ce8831cd3f8Variant3
            )
        {
            Shared947f69fa305d000e = shared947f69fa305d000e;
            AutoSDKShareda2a71ce8831cd3f8Variant2 = autoSDKShareda2a71ce8831cd3f8Variant2;
            AutoSDKShareda2a71ce8831cd3f8Variant3 = autoSDKShareda2a71ce8831cd3f8Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKShareda2a71ce8831cd3f8Variant3 as object ??
            AutoSDKShareda2a71ce8831cd3f8Variant2 as object ??
            Shared947f69fa305d000e as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared947f69fa305d000e?.ToString() ??
            AutoSDKShareda2a71ce8831cd3f8Variant2?.ToString() ??
            AutoSDKShareda2a71ce8831cd3f8Variant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared947f69fa305d000e && !IsAutoSDKShareda2a71ce8831cd3f8Variant2 && !IsAutoSDKShareda2a71ce8831cd3f8Variant3 || !IsShared947f69fa305d000e && IsAutoSDKShareda2a71ce8831cd3f8Variant2 && !IsAutoSDKShareda2a71ce8831cd3f8Variant3 || !IsShared947f69fa305d000e && !IsAutoSDKShareda2a71ce8831cd3f8Variant2 && IsAutoSDKShareda2a71ce8831cd3f8Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared947f69fa305d000e, TResult>? shared947f69fa305d000e = null,
            global::System.Func<global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2, TResult>? autoSDKShareda2a71ce8831cd3f8Variant2 = null,
            global::System.Func<global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3, TResult>? autoSDKShareda2a71ce8831cd3f8Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared947f69fa305d000e is { } __value0 && shared947f69fa305d000e != null)
            {
                return shared947f69fa305d000e(__value0);
            }
            else if (AutoSDKShareda2a71ce8831cd3f8Variant2 is { } __value1 && autoSDKShareda2a71ce8831cd3f8Variant2 != null)
            {
                return autoSDKShareda2a71ce8831cd3f8Variant2(__value1);
            }
            else if (AutoSDKShareda2a71ce8831cd3f8Variant3 is { } __value2 && autoSDKShareda2a71ce8831cd3f8Variant3 != null)
            {
                return autoSDKShareda2a71ce8831cd3f8Variant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared947f69fa305d000e>? shared947f69fa305d000e = null,

            global::System.Action<global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2>? autoSDKShareda2a71ce8831cd3f8Variant2 = null,

            global::System.Action<global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3>? autoSDKShareda2a71ce8831cd3f8Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared947f69fa305d000e is { } __value0)
            {
                shared947f69fa305d000e?.Invoke(__value0);
            }
            else if (AutoSDKShareda2a71ce8831cd3f8Variant2 is { } __value1)
            {
                autoSDKShareda2a71ce8831cd3f8Variant2?.Invoke(__value1);
            }
            else if (AutoSDKShareda2a71ce8831cd3f8Variant3 is { } __value2)
            {
                autoSDKShareda2a71ce8831cd3f8Variant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared947f69fa305d000e>? shared947f69fa305d000e = null,
            global::System.Action<global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2>? autoSDKShareda2a71ce8831cd3f8Variant2 = null,
            global::System.Action<global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3>? autoSDKShareda2a71ce8831cd3f8Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared947f69fa305d000e is { } __value0)
            {
                shared947f69fa305d000e?.Invoke(__value0);
            }
            else if (AutoSDKShareda2a71ce8831cd3f8Variant2 is { } __value1)
            {
                autoSDKShareda2a71ce8831cd3f8Variant2?.Invoke(__value1);
            }
            else if (AutoSDKShareda2a71ce8831cd3f8Variant3 is { } __value2)
            {
                autoSDKShareda2a71ce8831cd3f8Variant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared947f69fa305d000e,
                typeof(global::Vercel.AutoSDKShared947f69fa305d000e),
                AutoSDKShareda2a71ce8831cd3f8Variant2,
                typeof(global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2),
                AutoSDKShareda2a71ce8831cd3f8Variant3,
                typeof(global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3),
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
        public bool Equals(AutoSDKShareda2a71ce8831cd3f8 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared947f69fa305d000e?>.Default.Equals(Shared947f69fa305d000e, other.Shared947f69fa305d000e) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2?>.Default.Equals(AutoSDKShareda2a71ce8831cd3f8Variant2, other.AutoSDKShareda2a71ce8831cd3f8Variant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant3?>.Default.Equals(AutoSDKShareda2a71ce8831cd3f8Variant3, other.AutoSDKShareda2a71ce8831cd3f8Variant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShareda2a71ce8831cd3f8 obj1, AutoSDKShareda2a71ce8831cd3f8 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShareda2a71ce8831cd3f8>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShareda2a71ce8831cd3f8 obj1, AutoSDKShareda2a71ce8831cd3f8 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShareda2a71ce8831cd3f8 o && Equals(o);
        }
    }
}
