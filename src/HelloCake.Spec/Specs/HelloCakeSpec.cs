using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HelloCake.Spec.Specs
{
    public class HelloCakeSpec
    {
        private readonly Writer _writer;

        public HelloCakeSpec() => this._writer = new Writer();

        [Theory(DisplayName = "given a name when print greeting message then print name")
            , Trait("Category", "Spec")
            , InlineData("Peter")
            , InlineData("Lois")
            , InlineData("Christopher")
            , InlineData("Megan")
            , InlineData("Stewart")
            , InlineData("Brian")]
        public void ScenarioWithKnowName(string name)
        {
            // Act
            string greeting = this._writer.Greeting(name);

            // Assert
            Assert.Equal($"Hello {name}!", greeting);
        }

        [Theory(DisplayName = "given an empty name when print greeting message then print name")
            , Trait("Category", "Spec")
            , InlineData("")
            , InlineData(null)]
        public void ScenarioWithUnknown(string name)
        {
            // Act
            string greeting = this._writer.Greeting(name);

            // Assert
            Assert.Equal($"Yo Bro!", greeting);
        }
    }
}
