namespace Builders
{
    public class SimpleBuilder
    {
        public bool IsInputDivisibleByTwo(int input)
        {
            if (input == 0)
            {
                return false;
            }
            return input % 3 == 0;
        }
    }
}