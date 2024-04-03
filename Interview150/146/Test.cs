using FluentAssertions;
using NUnit.Framework;

namespace Interview150._146;

[TestFixture]
public class Test
{
    [Test]
    public void Case1()
    {
        var lru = new LRUCache(2);
        lru.Put(1, 1);
        lru.Put(2, 2);
        lru.Get(1).Should().Be(1);

        lru.Put(3, 3);
        lru.Get(2).Should().Be(-1);
        lru.Put(4, 4);
        lru.Get(1).Should().Be(-1);
        lru.Get(3).Should().Be(3);
        lru.Get(4).Should().Be(4);
    }
}