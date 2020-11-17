using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EstudandoAppiumCSharp.Fixtures
{
    [CollectionDefinition("AppiumDriver")]
    public class CollectionFixture : ICollectionFixture<TesteFixtures>
    {

    }
}
