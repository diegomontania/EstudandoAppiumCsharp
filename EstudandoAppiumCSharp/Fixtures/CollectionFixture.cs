using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EstudandoAppiumCSharp.Fixtures
{
    [CollectionDefinition("ActorAppiumDriver")]
    public class CollectionFixture : ICollectionFixture<TesteFixtures>
    {

    }
}
