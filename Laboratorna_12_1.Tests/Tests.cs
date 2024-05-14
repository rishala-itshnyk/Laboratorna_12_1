namespace Laboratorna_12_1.Tests;

public class Tests
{
    [Test]
    public void TestNodeDeletion()
    {
        Program.Node p = new Program.Node(); // Node 'p'
        p.info = 1; // Node 1
        p.link1 = new Program.Node(); // Node 1 points to Node 2
        p.link1.info = 2; // Node 2
        p.link1.link2 = p; // Node 2 points back to Node 1
        p.link2 = new Program.Node(); // Node 1 points to Node 3
        p.link2.info = 3; // Node 3
        p.link2.link1 = p; // Node 3 points back to Node 1
        p.link2.link2 = null; // Node 3 points to nowhere

        p.link2.link1 = null; // Unlink Node 3 from Node 1
        p.link2 = null; // Delete Node 3
        p.link1 = null; // Delete Node 2
        p = null; // Delete Node 1 (or 'p')

        Assert.IsNull(p);
    }
}