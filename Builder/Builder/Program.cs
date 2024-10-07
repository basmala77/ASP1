namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new PropertyBuilder().SetAddress("123 Main st.")
                .WithPropertyType(PropertyType.Apartment)
                .WithTransactionType(TransactionType.Rent)
                .SetPrice(2_000).Build();

            Console.WriteLine(p1);
        }
    }
}
