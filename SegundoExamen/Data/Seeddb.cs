namespace SegundoExamen.Data
{
    public class Seeddb
    {
        private readonly DataContext context;
        private Random random;
        public Seeddb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }
        public async Task SeedAsyncn()
        {
            await this.context.Database.EnsureCreatedAsync();
            if (this.context.context.Any  ())
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


