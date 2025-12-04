using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json2SharpLib.Enums;

/// <summary>
/// Represents the libraries whose serialization attributes are necessary
/// for the correct de/serialization of JSON objects.
/// </summary>
public enum JavaSerializationAttribute : byte
{
    /// <summary>
    /// No serialization attribute.
    /// </summary>
    NoAttribute,

    /// <summary>
    /// com.fasterxml.jackson - JsonProperty
    /// </summary>
    Jackson,
}
