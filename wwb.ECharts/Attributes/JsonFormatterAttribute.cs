using System;
using wwb.ECharts.Option;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Attributes
{
    /// <summary>
    /// Define the JSON format for this property. First the name of the property and then the value.
    /// <example>
    /// Example: {0}: '{1}'
    /// </example>
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class JsonFormatterAttribute : Attribute
    {
        public JsonFormatterAttribute(string jsonValueFormat = "", bool addPropertyName = true, bool useCurlyBracketsForObject = true) { JsonFormatter = new JsonFormatter { JsonValueFormat = jsonValueFormat, AddPropertyName = addPropertyName, UseCurlyBracketsForObject = useCurlyBracketsForObject }; }

        public JsonFormatter JsonFormatter { get; private set; }
    }
}