using Json2SharpLib;
using Json2SharpLib.Enums;
using Json2SharpLib.Models;
using Json2SharpTests.JavaTests.Models.Answers;
using Kotz.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json2SharpTests.JavaTests;
public sealed class JavaDataTests
{
    [Theory]
    [InlineData(nameof(IntegerTypes), IntegerTypes.Input, IntegerTypes.RecordPrimaryCtorOutputNoAtt, JavaObjectType.Record, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(IntegerTypes), IntegerTypes.Input, IntegerTypes.RecordOutput, JavaObjectType.Record, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(IntegerTypes), IntegerTypes.Input, IntegerTypes.ClassOutputNoAtt, JavaObjectType.Class, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(IntegerTypes), IntegerTypes.Input, IntegerTypes.ClassOutput, JavaObjectType.Class, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(FloatTypes), FloatTypes.Input, FloatTypes.RecordPrimaryCtorOutputNoAtt, JavaObjectType.Record, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(FloatTypes), FloatTypes.Input, FloatTypes.RecordOutput, JavaObjectType.Record, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(FloatTypes), FloatTypes.Input, FloatTypes.ClassOutputNoAtt, JavaObjectType.Class, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(FloatTypes), FloatTypes.Input, FloatTypes.ClassOutput, JavaObjectType.Class, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(TextTypes), TextTypes.Input, TextTypes.RecordPrimaryCtorOutputNoAtt, JavaObjectType.Record, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(TextTypes), TextTypes.Input, TextTypes.RecordOutput, JavaObjectType.Record, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(TextTypes), TextTypes.Input, TextTypes.ClassOutputNoAtt, JavaObjectType.Class, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(TextTypes), TextTypes.Input, TextTypes.ClassOutput, JavaObjectType.Class, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(BoolTypes), BoolTypes.Input, BoolTypes.RecordPrimaryCtorOutputNoAtt, JavaObjectType.Record, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(BoolTypes), BoolTypes.Input, BoolTypes.RecordOutput, JavaObjectType.Record, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(BoolTypes), BoolTypes.Input, BoolTypes.ClassOutputNoAtt, JavaObjectType.Class, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(BoolTypes), BoolTypes.Input, BoolTypes.ClassOutput, JavaObjectType.Class, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(ObjectTypes), ObjectTypes.Input, ObjectTypes.RecordPrimaryCtorOutputNoAtt, JavaObjectType.Record, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(ObjectTypes), ObjectTypes.Input, ObjectTypes.RecordOutput, JavaObjectType.Record, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(ObjectTypes), ObjectTypes.Input, ObjectTypes.ClassOutputNoAtt, JavaObjectType.Class, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(ObjectTypes), ObjectTypes.Input, ObjectTypes.ClassOutput, JavaObjectType.Class, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(ArrayTypes), ArrayTypes.Input, ArrayTypes.RecordPrimaryCtorOutputNoAtt, JavaObjectType.Record, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(ArrayTypes), ArrayTypes.Input, ArrayTypes.RecordOutput, JavaObjectType.Record, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(ArrayTypes), ArrayTypes.Input, ArrayTypes.ClassOutputNoAtt, JavaObjectType.Class, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(ArrayTypes), ArrayTypes.Input, ArrayTypes.ClassOutput, JavaObjectType.Class, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(ArrayRoot), ArrayRoot.Input, ArrayRoot.RecordPrimaryCtorOutputNoAtt, JavaObjectType.Record, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(ArrayRoot), ArrayRoot.Input, ArrayRoot.RecordOutput, JavaObjectType.Record, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(ArrayRoot), ArrayRoot.Input, ArrayRoot.ClassOutputNoAtt, JavaObjectType.Class, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(ArrayRoot), ArrayRoot.Input, ArrayRoot.ClassOutput, JavaObjectType.Class, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(WeirdNameTypes), WeirdNameTypes.Input, WeirdNameTypes.RecordPrimaryCtorOutputNoAtt, JavaObjectType.Record, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(WeirdNameTypes), WeirdNameTypes.Input, WeirdNameTypes.RecordOutput, JavaObjectType.Record, JavaSerializationAttribute.Jackson)]
    [InlineData(nameof(WeirdNameTypes), WeirdNameTypes.Input, WeirdNameTypes.ClassOutputNoAtt, JavaObjectType.Class, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(WeirdNameTypes), WeirdNameTypes.Input, WeirdNameTypes.ClassOutput, JavaObjectType.Class, JavaSerializationAttribute.Jackson)]
    [InlineData("EmptyObject", "{}", "", JavaObjectType.Record, JavaSerializationAttribute.NoAttribute)]
    [InlineData("EmptyObject", "{}", "", JavaObjectType.Record, JavaSerializationAttribute.Jackson)]
    [InlineData("EmptyObject", "{}", "", JavaObjectType.Class, JavaSerializationAttribute.Jackson)]
    internal void OutputTest(string className, string input, string expectedOutput, JavaObjectType targetType, JavaSerializationAttribute serializationAttribute)
    {
        var options = new Json2SharpOptions()
        {
            TargetLanguage = Language.Java,
            JavaOptions = new()
            {
                TargetType = targetType,
                SerializationAttribute = serializationAttribute
            }
        };

        var actualOutput = Json2Sharp.Parse(className, input, options);

        Assert.Equal(
            expectedOutput.Replace("\r", string.Empty),
            actualOutput.Replace("\r", string.Empty)
        );
    }

    [Theory]
    [InlineData(nameof(CustomHandleTypes), CustomHandleTypes.Input, CustomHandleTypes.RecordPrimaryCtorOutputNoAtt, JavaObjectType.Record, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(CustomHandleTypes), CustomHandleTypes.Input, CustomHandleTypes.ClassOutputNoAtt, JavaObjectType.Class, JavaSerializationAttribute.NoAttribute)]
    [InlineData(nameof(CustomHandleTypes), CustomHandleTypes.Input, CustomHandleTypes.ClassOutput, JavaObjectType.Class, JavaSerializationAttribute.Jackson)]
    internal void TypeHandleOutputTest(string className, string input, string expectedOutput, JavaObjectType targetType, JavaSerializationAttribute serializationAttribute)
    {
        var options = new Json2SharpOptions()
        {
            TargetLanguage = Language.Java,

            JavaOptions = new()
            {
                TargetType = targetType,
                SerializationAttribute = serializationAttribute,
                TypeNameHandler = propertyType => propertyType.ToSnakeCase()
            }
        };

        var actualOutput = Json2Sharp.Parse(className.ToSnakeCase(), input, options);

        Assert.Equal(
            expectedOutput.Replace("\r", string.Empty),
            actualOutput.Replace("\r", string.Empty)
        );
    }


    [Theory]
    [InlineData(ArrayRoot.BadInput1)]
    [InlineData(ArrayRoot.BadInput2)]
    [InlineData(ArrayRoot.BadInput3)]
    [InlineData(ArrayRoot.BadInput4)]
    internal void FailTest(string input)
        => Assert.Throws<InvalidOperationException>(() => Json2Sharp.Parse("Root", input));
}
