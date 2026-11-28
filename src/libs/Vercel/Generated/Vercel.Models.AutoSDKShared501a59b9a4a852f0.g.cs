#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared501a59b9a4a852f0 : global::System.IEquatable<AutoSDKShared501a59b9a4a852f0>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShareda3e211e8bee7aaa5? Shareda3e211e8bee7aaa5 { get; init; }
#else
        public global::Vercel.AutoSDKShareda3e211e8bee7aaa5? Shareda3e211e8bee7aaa5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shareda3e211e8bee7aaa5))]
#endif
        public bool IsShareda3e211e8bee7aaa5 => Shareda3e211e8bee7aaa5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShareda3e211e8bee7aaa5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShareda3e211e8bee7aaa5? value)
        {
            value = Shareda3e211e8bee7aaa5;
            return IsShareda3e211e8bee7aaa5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShareda3e211e8bee7aaa5 PickShareda3e211e8bee7aaa5() => Shareda3e211e8bee7aaa5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shareda3e211e8bee7aaa5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared2b02cf1378da97a7? Shared2b02cf1378da97a7 { get; init; }
#else
        public global::Vercel.AutoSDKShared2b02cf1378da97a7? Shared2b02cf1378da97a7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared2b02cf1378da97a7))]
#endif
        public bool IsShared2b02cf1378da97a7 => Shared2b02cf1378da97a7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared2b02cf1378da97a7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared2b02cf1378da97a7? value)
        {
            value = Shared2b02cf1378da97a7;
            return IsShared2b02cf1378da97a7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared2b02cf1378da97a7 PickShared2b02cf1378da97a7() => Shared2b02cf1378da97a7 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared2b02cf1378da97a7' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared501a59b9a4a852f0(global::Vercel.AutoSDKShareda3e211e8bee7aaa5 value) => new AutoSDKShared501a59b9a4a852f0((global::Vercel.AutoSDKShareda3e211e8bee7aaa5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShareda3e211e8bee7aaa5?(AutoSDKShared501a59b9a4a852f0 @this) => @this.Shareda3e211e8bee7aaa5;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared501a59b9a4a852f0(global::Vercel.AutoSDKShareda3e211e8bee7aaa5? value)
        {
            Shareda3e211e8bee7aaa5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared501a59b9a4a852f0 FromShareda3e211e8bee7aaa5(global::Vercel.AutoSDKShareda3e211e8bee7aaa5? value) => new AutoSDKShared501a59b9a4a852f0(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared501a59b9a4a852f0(global::Vercel.AutoSDKShared2b02cf1378da97a7 value) => new AutoSDKShared501a59b9a4a852f0((global::Vercel.AutoSDKShared2b02cf1378da97a7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared2b02cf1378da97a7?(AutoSDKShared501a59b9a4a852f0 @this) => @this.Shared2b02cf1378da97a7;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared501a59b9a4a852f0(global::Vercel.AutoSDKShared2b02cf1378da97a7? value)
        {
            Shared2b02cf1378da97a7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared501a59b9a4a852f0 FromShared2b02cf1378da97a7(global::Vercel.AutoSDKShared2b02cf1378da97a7? value) => new AutoSDKShared501a59b9a4a852f0(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared501a59b9a4a852f0(
            global::Vercel.AutoSDKShareda3e211e8bee7aaa5? shareda3e211e8bee7aaa5,
            global::Vercel.AutoSDKShared2b02cf1378da97a7? shared2b02cf1378da97a7
            )
        {
            Shareda3e211e8bee7aaa5 = shareda3e211e8bee7aaa5;
            Shared2b02cf1378da97a7 = shared2b02cf1378da97a7;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared2b02cf1378da97a7 as object ??
            Shareda3e211e8bee7aaa5 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shareda3e211e8bee7aaa5?.ToString() ??
            Shared2b02cf1378da97a7?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShareda3e211e8bee7aaa5 && !IsShared2b02cf1378da97a7 || !IsShareda3e211e8bee7aaa5 && IsShared2b02cf1378da97a7;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShareda3e211e8bee7aaa5, TResult>? shareda3e211e8bee7aaa5 = null,
            global::System.Func<global::Vercel.AutoSDKShared2b02cf1378da97a7, TResult>? shared2b02cf1378da97a7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shareda3e211e8bee7aaa5 is { } __value0 && shareda3e211e8bee7aaa5 != null)
            {
                return shareda3e211e8bee7aaa5(__value0);
            }
            else if (Shared2b02cf1378da97a7 is { } __value1 && shared2b02cf1378da97a7 != null)
            {
                return shared2b02cf1378da97a7(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>? shareda3e211e8bee7aaa5 = null,

            global::System.Action<global::Vercel.AutoSDKShared2b02cf1378da97a7>? shared2b02cf1378da97a7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shareda3e211e8bee7aaa5 is { } __value0)
            {
                shareda3e211e8bee7aaa5?.Invoke(__value0);
            }
            else if (Shared2b02cf1378da97a7 is { } __value1)
            {
                shared2b02cf1378da97a7?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>? shareda3e211e8bee7aaa5 = null,
            global::System.Action<global::Vercel.AutoSDKShared2b02cf1378da97a7>? shared2b02cf1378da97a7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shareda3e211e8bee7aaa5 is { } __value0)
            {
                shareda3e211e8bee7aaa5?.Invoke(__value0);
            }
            else if (Shared2b02cf1378da97a7 is { } __value1)
            {
                shared2b02cf1378da97a7?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shareda3e211e8bee7aaa5,
                typeof(global::Vercel.AutoSDKShareda3e211e8bee7aaa5),
                Shared2b02cf1378da97a7,
                typeof(global::Vercel.AutoSDKShared2b02cf1378da97a7),
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
        public bool Equals(AutoSDKShared501a59b9a4a852f0 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShareda3e211e8bee7aaa5?>.Default.Equals(Shareda3e211e8bee7aaa5, other.Shareda3e211e8bee7aaa5) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared2b02cf1378da97a7?>.Default.Equals(Shared2b02cf1378da97a7, other.Shared2b02cf1378da97a7)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared501a59b9a4a852f0 obj1, AutoSDKShared501a59b9a4a852f0 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared501a59b9a4a852f0>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared501a59b9a4a852f0 obj1, AutoSDKShared501a59b9a4a852f0 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared501a59b9a4a852f0 o && Equals(o);
        }
    }
}
