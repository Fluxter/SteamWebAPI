namespace PortableSteam.Infrastructure.Objects
{
    using System;
    /// <summary>
    /// Key value pair used for QueryStringDictionary.
    /// </summary>
    public class QueryStringKeyValuePair
    {
        private string _key;
        private object _value;
        /// <summary>
        /// Key of this pair.
        /// </summary>
        public string Key { get { return _key; } }
        /// <summary>
        /// Value of this pair.
        /// </summary>
        public object Value { get { return _value; } }

        public QueryStringKeyValuePair(string key, string value)
        {
            _key = key;
            _value = value;
        }
    }
}
