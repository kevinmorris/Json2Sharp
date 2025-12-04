using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json2SharpLib.Enums;

/// <summary>
/// Represents the level of accessibility a Java class member can have.
/// </summary>
public enum JavaAccessibilityLevel : byte
{
    /// <summary>
    /// Access is not restricted.
    /// </summary>
    Public,

    /// <summary>
    /// Access is limited to the containing class or types derived from the containing class.
    /// </summary>
    Protected,

    /// <summary>
    /// Access is limited to the current package.
    /// </summary>
    PackageProtected,

    /// <summary>
    /// Access is limited to the containing type.
    /// </summary>
    Private
}
