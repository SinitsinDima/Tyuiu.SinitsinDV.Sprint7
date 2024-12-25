using Tyuiu.SinitsinDV.Sprint7.Project.V3.Lib;
namespace Tyuiu.SinitsinDV.Sprint7.Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcAverageGrades()
        {

            var Grades = new List<int> { 1, 2, 3, 4, 5 };
            var res = DataService.CalculateAverageGrade(Grades);
            double wait = 3;
            Assert.AreEqual(wait, res);


        }
    }
}