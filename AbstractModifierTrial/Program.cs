using System.Text.Json;

namespace AbstractModifierTrial
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var transaction = new Transaction();

            transaction.Id = "1a2s3d4f5";
            transaction.BusinessType = "new";
            transaction.CreatedBy = "system";
            transaction.CreatedDate = DateTime.Now;

            Console.WriteLine(JsonSerializer.Serialize(transaction));
        }
    }
}
