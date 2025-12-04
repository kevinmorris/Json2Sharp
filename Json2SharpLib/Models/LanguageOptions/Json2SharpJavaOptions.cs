using Json2SharpLib.Enums;
using Json2SharpLib.Models.LanguageOptions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json2SharpLib.Models.LanguageOptions;
public sealed record Json2SharpJavaOptions : BaseLanguageOptions
{
    /// <summary>
    /// The accessibility level of the type. <br />
    /// Default is <see cref="CSharpAccessibilityLevel.Public"/>.
    /// </summary>
    public JavaAccessibilityLevel AccessibilityLevel { get; init; } = JavaAccessibilityLevel.Public;

    /// <summary>
    /// The type definition to generate in the output. <br />
    /// Default is <see cref="JavaObjectType.Record"/>.
    /// </summary>
    public JavaObjectType TargetType { get; init; } = JavaObjectType.Class;

    /// <summary>
    /// The library serialization attribute to use. <br />
    /// Default is <see cref="JavaSerializationAttribute.Jackson"/>.
    /// </summary>
    public JavaSerializationAttribute SerializationAttribute { get; init; } = JavaSerializationAttribute.Jackson;

    public override Func<string, string> TypeNameHandler { get; init; } = static propertyName => propertyName.ToCamelCase();
}
