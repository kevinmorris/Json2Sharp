using Json2SharpLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json2SharpLib.Models.LanguageOptions;
public sealed class Json2SharpJavaOptions
{
    /// <summary>
    /// The accessibility level of the type. <br />
    /// Default is <see cref="CSharpAccessibilityLevel.Public"/>.
    /// </summary>
    public JavaAccessibilityLevel AccessibilityLevel { get; init; } = JavaAccessibilityLevel.Public;
}
