namespace WebApplication1.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<string> CheckForFizzBuzz(List<object> nos)
        {
            List<string> result = new List<string>();
            if (nos != null)
            {
                nos.ForEach(n =>
                {
                    if (n == null || string.IsNullOrEmpty(n.ToString()) || string.IsNullOrWhiteSpace(n.ToString()) || !Int32.TryParse(n.ToString(), out int no))
                    {
                        result.Add("Invalid Item");
                    }
                    else
                    {
                        if (no % 3 == 0 && no % 5 == 0)
                        {
                            result.Add("FizzBuzz");

                        }
                        else if (no % 3 == 0)
                        {
                            result.Add("Fizz");
                        }
                        else if (no % 5 == 0)
                        {
                            result.Add("Buzz");
                        }
                        else
                        {
                            result.Add(String.Format("Divided {0} by 3", n));
                            result.Add(String.Format("Divided {0} by 5", n));
                        }
                    }
                });
            }
            return result;

        }
    }
}
