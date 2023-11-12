using System.Formats.Asn1;

namespace HotTests;

[TestClass]
public class TestGivenFiles
{
    private static IEnumerable<object[]> GetTestDataForCategory(string category) {
        List<object[]> testDatas = new List<object[]>();

        string path = "../../../TestCases/" + category;
        string[] succeedFiles = Directory.GetFiles(path + "/success");
        foreach (string succeedFile in succeedFiles)
        {
            testDatas.Add(new object[]{succeedFile, true});
        }

        string[] failFiles = Directory.GetFiles(path + "/fail");
        foreach (string failFile in failFiles)
        {
            testDatas.Add(new object[]{failFile, false});
        }

        return testDatas;
    }

    private static void TestSingleTestData(string filePath, bool success) {
        if (success)
        {
            NodeProgram? ast = Program.BuildAST(filePath);
            Assert.IsNotNull(ast, filePath);  
        }
        else
        {
            Assert.ThrowsException<Exception>(() =>
            {
                Program.BuildAST(filePath);
            });
        }
    }

    static IEnumerable<object[]> AlgorithmTestData { get => GetTestDataForCategory("Algorithm"); }
    static IEnumerable<object[]> ParsingTestData { get => GetTestDataForCategory("Parsing"); }
    static IEnumerable<object[]> SemanticsTestData { get => GetTestDataForCategory("Semantics"); }

    [TestMethod]
    [DynamicData(nameof(AlgorithmTestData))]
    public void TestAlgorithm(string filePath, bool success) => TestSingleTestData(filePath, success);

    [TestMethod]
    [DynamicData(nameof(ParsingTestData))]
    public void TestParsing(string filePath, bool success) => TestSingleTestData(filePath, success);

    [TestMethod]
    [DynamicData(nameof(SemanticsTestData))]
    public void TestSemantics(string filePath, bool success) => TestSingleTestData(filePath, success);

}