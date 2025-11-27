using Bogus;
using ShopBackend.Model;

namespace ShopBackend.Seed
{
    public static class FakeProductGenerator
    {
        public static List<Product> GeneratorProductList(int count = 50)
        {
            var products = new[] { "Категория 1", "Категория 2", "Категория 3" };
            var specialTags = new[] { "Новинка", "Популярный", "Рекомендуемый" };

            return new Faker<Product>("ru")
                 .RuleFor(m => m.Id, f => f.IndexFaker + 1)
                 .RuleFor(m => m.Name, f => f.Commerce.ProductName())
                 .RuleFor(m => m.Description, f => f.Lorem.Sentence())
                 .RuleFor(m => m.Category, f => f.PickRandom(products))
                 .RuleFor(m => m.SpecialTag, f => f.PickRandom(specialTags))
                 .RuleFor(m => m.Price, f => Math.Round(f.Random.Double(1, 1000), 2))
                 .RuleFor(m => m.Image, f => $"https://placehold.co/200")
                 .Generate(count);
        }
    }
}
