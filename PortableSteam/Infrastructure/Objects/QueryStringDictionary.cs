namespace PortableSteam.Infrastructure.Objects
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class QueryStringDictionary : IEnumerable<QueryStringKeyValuePair>
    {
        private List<QueryStringKeyValuePair> _values;

        public QueryStringDictionary()
        {
            _values = new List<QueryStringKeyValuePair>();
        }

        public void Add(string key, object value)
        {
            if (_values.Select(x => x.Key).Contains(key))
            {
                throw new ArgumentException("key already exists.");
            }

            var stringValue = value.ToLowerString();
            if (string.IsNullOrEmpty(stringValue))
            {
                throw new ArgumentNullException("Value cannot be null.");
            }

            _values.Add(new QueryStringKeyValuePair(key, stringValue));
        }

        public void AddRange(QueryStringDictionary items)
        {
            foreach (var item in items)
            {
                _values.Add(item);
            }
        }

        /// <summary>
        /// Converts this dictionary of parameters into URL compatible string.
        /// </summary>
        /// <returns></returns>
        public string ToQueryString()
        {
            return string.Join("&", this.Where(x => x.Value != null)
                                        .Select(x => Uri.EscapeDataString(x.Key) + "=" + Uri.EscapeDataString(x.Value.ToNullableString())));
        }

        public IEnumerator<QueryStringKeyValuePair> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
