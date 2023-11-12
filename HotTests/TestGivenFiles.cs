using System.Formats.Asn1;
using System.Reflection;

namespace HotTests;

[TestClass]
public class TestGivenFiles
{
    public static string GetTestDisplayName(MethodInfo methodInfo, object[] values) {
        string path = Path.GetFileName((string) values[0]);
        bool success = (bool) values[1];
        return success ? "should succeed: " + path : "should fail: " + path;
    }

    private static IEnumerable<object[]> GetTestDataForCategory(string category) {
        List<object[]> testDatas = new List<object[]>();

        string path = "../../../TestCases/" + category;
        foreach (string succeedFile in Directory.GetFiles(path + "/success"))
        {
            testDatas.Add(new object[]{succeedFile, true});
        }
        foreach (string failFile in Directory.GetFiles(path + "/fail"))
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
            Assert.ThrowsException<ParsingException>(() =>
            {
                Program.BuildAST(filePath);
            });
        }
    }

    static IEnumerable<object[]> AlgorithmTestData { get => GetTestDataForCategory("Algorithm"); }
    static IEnumerable<object[]> ParsingTestData { get => GetTestDataForCategory("Parsing"); }
    static IEnumerable<object[]> SemanticsTestData { get => GetTestDataForCategory("Semantics"); }

    [TestMethod]
    [DynamicData(nameof(AlgorithmTestData), DynamicDataDisplayName=nameof(GetTestDisplayName))]
    public void TestAlgorithm(string filePath, bool success) => TestSingleTestData(filePath, success);

    [TestMethod]
    [DynamicData(nameof(ParsingTestData), DynamicDataDisplayName=nameof(GetTestDisplayName))]
    public void TestParsing(string filePath, bool success) => TestSingleTestData(filePath, success);

    [TestMethod]
    [DynamicData(nameof(SemanticsTestData), DynamicDataDisplayName=nameof(GetTestDisplayName))]
    public void TestSemantics(string filePath, bool success) => TestSingleTestData(filePath, success);

}