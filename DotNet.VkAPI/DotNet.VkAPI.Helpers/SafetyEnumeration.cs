using System;
using System.Collections.Generic;

namespace DotNet.VkAPI.Helpers
{
    public abstract class SafetyEnumeration<T> : IEqualityComparer<SafetyEnumeration<T>>, IEquatable<SafetyEnumeration<T>> where T : SafetyEnumeration<T>, new()
    {
        private string _value;

        protected static T RegisterPossibleValue(string v) => new T { _value = v };

        public static T FromJson(/*TODO:*/object response) => FromJsonString(response.ToString());

        public static T FromJsonString(string response) =>
             (string.IsNullOrWhiteSpace(response)) ? default : ActivateInstance(response);

        private static T ActivateInstance(string response)
        {
            var r = new T { _value = response };
            Activator.CreateInstance(new T { _value = response }.GetType());
            return r;
        }

        public override string ToString() => base.ToString();

        public static bool operator ==(SafetyEnumeration<T> l, SafetyEnumeration<T> r) =>
             (r == null || l == null) ? default : ReferenceEquals(r, l) ? true : r._value == l._value;

        public static bool operator !=(SafetyEnumeration<T> l, SafetyEnumeration<T> r) => !(l == r);

        public bool Equals(SafetyEnumeration<T> x, SafetyEnumeration<T> y) => x == y;

        public bool Equals(SafetyEnumeration<T> other) => Equals(this, other);

        public int GetHashCode(SafetyEnumeration<T> obj) => obj._value.GetHashCode();

        public override int GetHashCode() => base.GetHashCode();

        public override bool Equals(object obj) => base.Equals(obj);


    }
}
