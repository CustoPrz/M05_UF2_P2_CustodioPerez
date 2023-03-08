using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Tests
{
    [TestClass]
    public class ParenthesisChecker_Tests
    {
        [TestMethod]
        public void ParenthesisChecker_Test()
        {
            //Arrange
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Utils.random.Next(10,100); i++)
            {
                if(Utils.random.Next(2) > 0)
                {
                    sb.Append('(');
                }
                else
                {
                    sb.Append(')');
                }
            }
            string original = sb.ToString();
            bool resultOK = true;
            Stack<char> stack = new Stack<char>();
            foreach (char c in original)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        resultOK = false;
                        break; // Salir del ciclo para evitar errores adicionales
                    }
                    char last = stack.Pop();
                    if (c == ')' && last != '(')
                    {
                        resultOK = false;
                        break; // Salir del ciclo para evitar errores adicionales
                    }
                }
            }
            if (stack.Count != 0)
            {
                resultOK = false;
            }

            bool result = false;
            //Act
            result = ParenthesisChecker.Program.Valid(original);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
    }
}
