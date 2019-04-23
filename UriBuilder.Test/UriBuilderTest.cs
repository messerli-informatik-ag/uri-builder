using System;
using Xunit;

namespace Messerli.UriBuilder.Test
{
    public class UriBuilderTest
    {
        [Fact]
        public void BuildsRoot()
        {
            var expectedRoot = Root;
            var uri = new UriBuilder(expectedRoot).Build();

            Assert.Equal(expectedRoot, uri);
        }

        [Fact]
        public void AppendsPath()
        {
            var uri = new UriBuilder(Root)
                .Path("baz")
                .Build();
            var expectedRoot = new Uri($"{Root}baz");

            Assert.Equal(expectedRoot, uri);
        }

        [Fact]
        public void AppendsMultiplePaths()
        {
            var uri = new UriBuilder(Root)
                .Path("baz")
                .Path("quux")
                .Build();
            var expectedRoot = new Uri($"{Root}baz/quux");

            Assert.Equal(expectedRoot, uri);
        }


        [Fact]
        public void AppendsSanitizedPaths()
        {
            var uri = new UriBuilder(Root)
                .Path("//baz/")
                .Path("/quux///")
                .Build();
            var expectedRoot = new Uri($"{Root}baz/quux");

            Assert.Equal(expectedRoot, uri);
        }

        private static Uri Root => new Uri("https://foo.bar");
    }
}