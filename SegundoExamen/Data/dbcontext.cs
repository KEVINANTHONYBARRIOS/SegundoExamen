

namespace SegundoExamen.Data
{
    public class seedDb

    {
        private readonly DataContext context;
        private Random random;
        public seedDb(DataContext context)
        {
            this.context = context;
            this.random = random;
        }
        public async Task SeedAsyncn()
        {
            object = await this.context.DataContext.EnsureCreatedAsync();
            if (this.context.products.Any())
            {
                this.AddProduct("primera planta");
                this.AddProduct("segunda planta");
                this.AddProduct("tercera planta");
                await this.context.saveChangesAsync();

            }
        }

        private void AddProduct(string name)
        {
            this.context.products.Add(new Entity.Pantas
            name = name,
            price = this.random.Next,
            IsActive = true;

        });
    }
}
